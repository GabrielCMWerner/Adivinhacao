using System;

namespace Adivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {


                Console.Clear();

                Random aleatorio = new Random();
                int secreto = aleatorio.Next(20);
                int tentativas = Convert.ToInt32(0);
                int adivinhar;
                double pontuacaoinicial = 1000;

                Console.WriteLine(" *****************************************");
                Console.WriteLine(" * < Bem vindo ao jogo da adivinhação! > *");
                Console.WriteLine(" *****************************************");

                Console.WriteLine();

                Console.WriteLine(" selecione a dificuldade do jogo: ");
                Console.WriteLine(" (1) Fácil = 15 chances");
                Console.WriteLine(" (2) Médio = 10 chances");
                Console.WriteLine(" (3) Difícil = 5 chances");
                               
                int dificuldade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch (dificuldade)
                {
                    case 1:
                        tentativas = 15;
                            break;

                    case 2:
                        tentativas = 10;
                            break;

                    case 3:
                        tentativas = 5;
                            break;
                }

                
                for (int chutes = 1; chutes <= tentativas; chutes++)
                {
                    Console.WriteLine(" Tentativa " + chutes + " de " + tentativas);
                    Console.WriteLine("---------------------------------------------");
                    Console.Write(" Qual o seu chute? ");
                    adivinhar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();


                    if (adivinhar == secreto)
                    {
                        Console.WriteLine();

                        Console.WriteLine(" Você adivinhou! O número secreto é igual à " + secreto);

                        Console.WriteLine();

                        double pontuacaoperdida = Math.Abs((chutes - secreto) / 2);
                        pontuacaoinicial -= pontuacaoperdida;

                        Console.WriteLine(" A sua pontuação foi igual à " + pontuacaoinicial);
                        break;
                    }
                    
                    else if (adivinhar < secreto)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" O seu chute foi menor que o número secreto");
                        Console.WriteLine(" ------------------------------------------");
                        Console.WriteLine(); Console.WriteLine();
                    }

                    else if (adivinhar > secreto)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" O seu chute foi maior que o número secreto");
                        Console.WriteLine(" ------------------------------------------");
                        Console.WriteLine(); Console.WriteLine();
                    }

                    if (chutes == tentativas)
                    {
                        Console.WriteLine(" O número máximo de tentativas foi acansado.");
                    }
                                       
                }


                
                Console.WriteLine();
                break;
                

            }
            while (true);
        }
        
    }
}
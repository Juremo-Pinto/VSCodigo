using System;
namespace RandNumGame
{
    class Programinha
    {
        static void Main()
        {
            int stupid = 0;
            bool EBA = false;
            Random rnd = new Random();
            int num = rnd.Next(1, 101);
            Console.WriteLine("Ache o numero de 1 a 100: ");
            while (!EBA)
            {

                int guess = Convert.ToInt32(Console.ReadLine());
                stupid += 1;

                if (guess < num)
                {

                    Console.WriteLine("Errou pra baixo");
                }
                else if (guess > num)
                {

                    Console.WriteLine("Errou pra cima");
                }
                else if (guess > 101)
                {

                    Console.WriteLine("É abaixo de 100 abestalhado!");
                }
                else
                {

                    Console.WriteLine("Acertou!");
                    Console.Write($"Vc errou {stupid} vezes.");
                    EBA = true;
                }

            }

        }

    }

}
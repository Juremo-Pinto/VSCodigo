using System;
namespace Verificador
{
    class Programinha
    {
        static void Main()
        {
            Console.WriteLine("Numero inteiro: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                Console.Write("O numero é zero :|");
            }

            else if (num % 2 == 0)
            {
                Console.Write("O numero é par e ");

                posneg(num);
            }
            else
            {
                Console.Write("O numero é impar e ");

                posneg(num);
            }

        }
        static void posneg(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("é positivo!");
            }
            else
            {
                Console.WriteLine("é negativo!");
            }

        }
    }
}
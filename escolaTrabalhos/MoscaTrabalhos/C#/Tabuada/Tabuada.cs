using System;
namespace Tabuada
{
    class Programinha
    {
        static void falar(string m) => Console.Write(m);
        static int ouvir32() => Convert.ToInt32(Console.ReadLine());
        static void Main()
        {
            falar("Fala um numero ai: ");
            int num = ouvir32();
            falar($"Tabuada do {num}\n");

            for (int i = 1; i <= 10; i++)
            {

                falar($"{num} x {i} = {num * i}\n");
            }

        }

    }

}
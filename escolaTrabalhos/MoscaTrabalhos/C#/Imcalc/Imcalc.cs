using System;
using System.ComponentModel.Design;
namespace Imcalc
{
    class Programinha
    {
        static void Main()
        {
            Console.Write("Peso (kg): ");
            double kg = Convert.ToDouble(Console.ReadLine());

            Console.Write("Altura (cm): ");
            double cm = Convert.ToDouble(Console.ReadLine());

            Console.Write("IMC: ");
            double IMC = kg / (cm * cm);
            double redondo = Math.Round(IMC, 2);
            Console.WriteLine(redondo);

            func(IMC);


        }

        static void func(double IMC)
        {
            if (IMC < 18.5)
            {
                Console.WriteLine("Magresa");

            }
            else if (IMC < 24.9)
            {

                Console.WriteLine("Normal");

            }
            else if (IMC < 29.9)
            {

                Console.WriteLine("Sobrepeso");

            }
            else if (IMC < 39.9)
            {

                Console.WriteLine("Obesidade");

            }
            else
            {

                Console.WriteLine("Obesidade Morbida");

            }
        }

    }

}
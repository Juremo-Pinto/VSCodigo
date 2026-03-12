using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    class ProgramS
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o programa que deseja usar! 1 - Calculadora, 2 - Conversor de Temperatura");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    CalculadoraSimples();
                    break;
                case 2:
                    ConversorTemperatura();
                    break;
                default:
                    Console.WriteLine("Burro.");
                    break;
            }
        }
        static void CalculadoraSimples()
        {
            double resultado = 0;

            Console.WriteLine("Seja bem vindo! Blablabla, digite os dois números na qual você deseja usar!");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Decida a operação que você deseja fazer. (1 +, 2 -, 3 *, 4 /)");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Burro.");
                        return;
                    }
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("cadê os numero.");
                    break;
            }
            Console.WriteLine($"O resultado da sua operação é {resultado}.");
            Console.WriteLine("Aperte enter para sair.");
            Console.ReadKey();
        }

        static void ConversorTemperatura()
        {
            string sinal = "a";
            double tempFinal = 0;
            Console.WriteLine("Escolha: 1 - Celsius para Fahrenheit, 2 - Fahrenheit para Celsius.");
            int op = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com a temperatura desejada à converter.");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case 1:
                    tempFinal = (temperatura * 9 / 5) + 32;
                    sinal = "°F";
                    break;
                case 2:
                    tempFinal = (temperatura - 32) * 5 / 9;
                    sinal = "°C";
                    break;
            }
            Console.WriteLine($"A temperatura final é de {tempFinal}{sinal}.");
            Console.WriteLine("Aperte enter para sair.");
            Console.ReadKey();
        }
    }
}

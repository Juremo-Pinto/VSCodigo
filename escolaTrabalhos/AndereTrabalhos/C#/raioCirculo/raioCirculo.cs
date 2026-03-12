using System;
using System.Net.NetworkInformation;
namespace Tabuada
{
    class Programinha
    {
        static void falar(string m) => Console.Write(m);
        static int ouvir32() => Convert.ToInt32(Console.ReadLine());
        static double ouvir2() => Convert.ToDouble(Console.ReadLine());
        static void Main()
        {
            falar("Insira o raio do seu circulo: ");
            double raio = ouvir2();
            double area = 3.14159 * (raio * raio);
            falar($"A area do circulo é : {area}");
            
        }
    }
}
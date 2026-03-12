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
            falar("S = (A*B) - (C*D)\n");
            falar("A = ");
            int A = ouvir32();
            falar("B = ");
            int B = ouvir32();
            falar("C = ");
            int C = ouvir32();
            falar("D = ");
            int D = ouvir32();
            falar($"S = {(A * B) - (C * D)}");
        }
    }
}
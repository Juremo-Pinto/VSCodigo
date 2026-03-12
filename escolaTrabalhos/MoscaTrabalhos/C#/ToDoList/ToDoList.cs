using System;
using System.ComponentModel;
namespace Tabuada
{
    class Programinha
    {
        static void falar(string m) => Console.Write(m);
        static int ouvir32() => Convert.ToInt32(Console.ReadLine());
        static string ouvir() => Convert.ToString(Console.ReadLine());


        static void Main()
        {
            List<string> Tarefas = new List<string>();
            string power = ouvir();
            while (power == "Ligar Lista" || power == "ligar lista")
            {
                int opt = ouvir32();
                if (opt == 1)
                {
                    string addTarefa = ouvir();
                    Tarefas.Add(addTarefa);
                }

                else if (opt == 2)
                {
                    int delTarefa = ouvir32();
                    Tarefas.RemoveAt(delTarefa);
                }

                else if (opt == 3)
                {
                    foreach (string tarefa in Tarefas)
                    {
                        falar($"{tarefa}\n");
                    }

                }

                else if (opt == 4)
                {
                    return;
                }

                else
                {
                    falar("stupid\n");
                }

            }

        }

    }

}
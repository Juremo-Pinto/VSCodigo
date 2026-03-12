using System;
using System.Diagnostics;
using System.Net;
namespace Login
{
    class Programinha
    {
        static void Main()
        {
            string nome = "";
            int idade = 0;
            string cpf = "";
            string senha = "";

            while (true)
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                if (nome.Length > 20 || nome.Length < 2)
                {
                    Console.Write("Mentiroso de uma figa, ponha seu nome de verdade\n");
                    nome = "";
                }
                else
                {
                    while (true)
                    {
                        Console.Write("Idade: ");
                        idade = int.Parse(Console.ReadLine());
                        if (idade > 123)
                        {
                            Console.Write("Mentiroso de uma figa, ponha sua idade de verdade\n");
                            idade = 0;
                        }
                        else
                        {
                            while (true)
                            {
                                Console.Write("CPF: ");
                                cpf = Console.ReadLine();
                                if (cpf.Length != 11)
                                {
                                    Console.Write("Mentiroso de uma figa, ponha seu CPF de verdade\n");
                                    cpf = "";
                                }
                                else
                                {
                                    for (int i = 3; i > 0; i--)
                                    {
                                        Console.Write("Digite uma senha: ");
                                        senha = Console.ReadLine();
                                        Console.Write("Confirme a senha: ");
                                        string confirma = Console.ReadLine();
                                        if (confirma != senha)
                                        {
                                            Console.Write($"Tentativas restantes: {i - 1}\n");
                                        }
                                        else
                                        {
                                            Console.Write("LogOn efetuado com sucesso!");
                                            break;
                                        }
                                    }
                                    break;
                                }
                                break;
                            }
                            break;
                        }
                        break;
                    }
                    break;
                }
                break;
            }
        }
    }
}
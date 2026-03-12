using System;
namespace Login
{
    class Programinha
    {
        static void Main()
        {
            string nome = "Jelado1234";
            string senha = "1234";
            bool loginCorreto = false;
            int tentativas = 3;

            while (!loginCorreto)
            {
                Console.Write("Login: ");
                string? tentativaNome = Console.ReadLine();
                Console.Write("Senha: ");
                string? tentativaSenha = Console.ReadLine();

                if ((tentativaNome != nome || tentativaSenha != senha) && tentativas >= 1)
                {
                    tentativas -= 1;
                    Console.Write($"Erro: Login ou senha incorretos...\nTentativas restantes: {tentativas}\n");

                    if (tentativas == 0)
                    {
                        Console.Write("Erro: Tentativas de login excedidas\nTente novamente mais tarde\n");
                        return;
                    }

                }
                else if (tentativaNome == nome && tentativaSenha == senha)
                {
                    loginCorreto = true;
                    Console.Write("Bem vindo");
                    return;
                }

            }

        }

    }

}
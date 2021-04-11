using System;

namespace Aula_39
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];

            int escolha;
            int i = 0;


            //Validaçao de login
            bool senhaValida;
            do
            {
                Console.WriteLine("Digite sua senha: ");
                string senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);
            } while (!senhaValida);

            Console.Clear();
            //Menu
            do
            {
                Console.WriteLine("MENU \nEscolha uma opção: \n1 - Cadastrar passagem \n2 - Listar passagem \n0 - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        string continuar;

                        do
                        {
                            Console.Clear();
                            if (i < 5)
                            {
                                Console.WriteLine("Digite o nome do passageiro: ");
                                nome[i] = Console.ReadLine();
                                Console.WriteLine("Digite a origem do passageiro: ");
                                origem[i] = Console.ReadLine();
                                Console.WriteLine("Digite o destino do passageiro: ");
                                destino[i] = Console.ReadLine();
                                Console.WriteLine("Digite a data (DD/MM/AAAA) do voo: ");
                                data[i] = Console.ReadLine();

                                i = i + 1;
                            }
                            else
                            {
                                Console.WriteLine("Quantidade de passageiros completo");
                                break;
                            }

                            Console.WriteLine("Gostaria de cadastrar uma nova passagem? \nS - Sim \nN - Não");
                            continuar = Console.ReadLine();

                        } while (continuar == "S");
                        break;

                    case 2:
                        Console.Clear();
                        for (var x = 0; x < i; x++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine($"{x + 1}º Passageiro");
                            Console.ResetColor();
                            Console.WriteLine($"Nome: {nome[x]} \nOrigem: {origem[x]} \nDestino: {destino[x]} \nData: {data[x]}");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Você saiu do menu");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (escolha != 0);




            //Função para validar o login
            bool EfetuarLogin(string senha)
            {
                if (senha == "123456")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("A senha está incorreta. Tente novamente: ");
                    return false;
                }
            }



        }
    }
}

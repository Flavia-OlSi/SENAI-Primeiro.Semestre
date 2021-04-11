using System;
using Exercicio_2.classes;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular();

            int opcao = 0;

            Console.WriteLine("Digite a cor do celular: ");
            celular.cor = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite o modelo do celular: ");
            celular.modelo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Escolha o tamanho do celular: \n(1) - Pequeno \n(2) - Médio \n(3) - Grande");
            int tam = int.Parse(Console.ReadLine());
            if (tam == 1)
            {
                celular.tamanho = "Pequeno";
            }
            else if (tam == 2)
            {
                celular.tamanho = "Médio";
            }
            else
            {
                celular.tamanho = "Grande";
            }
            Console.Clear();

            Console.WriteLine("O celular está ligado? \n(S) - Sim \n(N) - Não");
            string resposta = Console.ReadLine();
            Console.Clear();
            if (resposta == "S" || resposta == "s" || opcao == 4)
            {
                celular.ligado = true;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{celular.Ligar()}");
                Console.ResetColor();

                Console.WriteLine("Deseja fazer alguma operação? \n(S) - Sim \n(N) - Não");
                string continuar = Console.ReadLine();
                Console.Clear();
                while (continuar == "S" || continuar == "s")
                {
                    Console.WriteLine("Escolha a opção que deseja realizar no celular: \n(1) - Fazer ligação \n(2) - Enviar mensagem \n(3) - Ver as configurações do celular \n(4) - Desligar");
                    opcao = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (opcao)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{celular.FazerLigacao()}");
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{celular.EnviarMensagem()}");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Modelo: {celular.modelo} \nCor: {celular.cor} \nTamanho: {celular.tamanho}");
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"{celular.Desligar()}");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opção inválida!");
                            break;
                    }

                    if (opcao != 4)
                    {
                        Console.ResetColor();
                        Console.WriteLine("Deseja fazer outra operação? \n(S) - Sim \n(N) - Não");
                        continuar = Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        continuar = "N";
                    }
                }
            }
            else
            {
                celular.ligado = false;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{celular.Desligar()}");
                Console.ResetColor();

                Console.WriteLine("Gostaria de ligar o celular? \n(S) - Sim \n(N) - Não");
                string resposta2 = Console.ReadLine();
                Console.Clear();
                if (resposta2 == "S" || resposta2 == "s")
                {
                    celular.ligado = true;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{celular.Ligar()}");
                    Console.ResetColor();

                    Console.WriteLine("Deseja fazer alguma operação? \n(S) - Sim \n(N) - Não");
                    string continuar = Console.ReadLine();
                    Console.Clear();
                    while (continuar == "S" || continuar == "s")
                    {
                        Console.WriteLine("Escolha a opção que deseja realizar no celular: \n(1) - Fazer ligação \n(2) - Enviar mensagem \n(3) - Ver as configurações do celular \n(4) - Desligar");
                        opcao = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opcao)
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{celular.FazerLigacao()}");
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{celular.EnviarMensagem()}");
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Modelo: {celular.modelo} \nCor: {celular.cor} \nTamanho: {celular.tamanho}");
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"{celular.Desligar()}");
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Opção inválida!");
                                break;
                        }

                        if (opcao != 4)
                        {
                            Console.ResetColor();
                            Console.WriteLine("Deseja fazer outra operação? \n(S) - Sim \n(N) - Não");
                            continuar = Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            continuar = "N";
                        }
                    }
                }
                else
                {
                    celular.ligado = false;
                }
            }
        }
    }
}
using System;

using Aula_48.Classes;

namespace Aula_48
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exemplo: classe Math
            Console.WriteLine(Math.Pow(2,4));*/

        
            //Chamamos nosssa classe estática, sem preciar instanciar

                Console.WriteLine("Escolha a moeda: \n1 - Dolar \n2 - Euro");
                int escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Desaja converter: \n1 - Real para dolar \n2 - Dolar para real");
                    int decisao = int.Parse(Console.ReadLine());
                    if (decisao == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite o valor em reias para converter para dolar: ");
                        float valor = float.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"US${Conversor.RealParaDolar(valor)}");
                        Console.ResetColor();
                    }
                    else if (decisao == 2)
                    {   
                        Console.Clear();
                        Console.WriteLine("Digite o valor em dolar para converter para reais: ");
                        float valor = float.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"R${Conversor.DolarParaReal(valor)}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção invalida");
                        Console.ResetColor();
                    }
                }
                else if (escolha == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Desaja converter: \n1 - Real para euro \n2 - Euro para real");
                    int decisao = int.Parse(Console.ReadLine());
                    if (decisao == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite o valor em reias para converter para euro: ");
                        float valor = float.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"€{Conversor.RealParaEuro(valor)}");
                        Console.ResetColor();
                    }
                    else if (decisao == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite o valor em euro para converter para reais: ");
                        float valor = float.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"R${Conversor.EuroParaReal(valor)}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção invalida");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção invalida");
                    Console.ResetColor();
                }
        }
    }
}

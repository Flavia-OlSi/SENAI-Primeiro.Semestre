using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados
            Console.WriteLine("Digite o ano atual: ");
            int anoAtual = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano de nascimento: ");
            int anoANasc = int.Parse(Console.ReadLine());

            //Processamento
            int idade = anoAtual - anoANasc;

            if(idade >= 16){
                Console.WriteLine($"Com essa idade ({idade} anos) já é permitido votar.");
            }else{
                Console.WriteLine($"Com essa idade ({idade} anos) não é permitido votar ainda.");
            }
        }
    }
}
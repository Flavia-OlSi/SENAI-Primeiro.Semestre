using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Entrada de dados
            Console.WriteLine("Digite o ano de nascimento: ");
            int anonasc = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano atual: ");
            int anoatual = int.Parse(Console.ReadLine());

            //Processamento
            int idadeEmAnos = (anoatual - anonasc);
            int idadeEmSem = (idadeEmAnos*52);

            //Exibição
            Console.Write("Sua idade em anos -> "+idadeEmAnos);
            Console.Write("/ Sua idade em semanas -> "+idadeEmSem);
        }
    }
}

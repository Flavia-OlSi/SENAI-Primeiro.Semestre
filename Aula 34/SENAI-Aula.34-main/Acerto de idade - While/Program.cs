using System;

namespace Acerto_de_idade___While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados
            Console.WriteLine("Jogo de acerto. Digite a idade do ator: ");
            int idade = int.Parse(Console.ReadLine());

            //Processamento
             while(idade != 47)
             {
                 Console.WriteLine("Errou!  Tente de novo. Digite a idade do ator: ");
                 idade = int.Parse(Console.ReadLine());
             }
             Console.WriteLine("Acertou, parabéns!!!");
        }
    }
}

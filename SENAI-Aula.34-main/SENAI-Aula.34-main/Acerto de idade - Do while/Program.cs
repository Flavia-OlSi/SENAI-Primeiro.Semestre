using System;

namespace Acerto_de_idade___Do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            do{
                Console.WriteLine("Jogo de acerto. \nDigite a idade do ator: ");
                idade = int.Parse(Console.ReadLine());
            }while(idade != 47);
                Console.WriteLine("Acertou, parabéns!!!");
            
        }
    }
}

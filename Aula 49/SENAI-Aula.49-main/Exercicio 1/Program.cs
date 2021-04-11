using System;
using Exercicio_1.classes;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Pessoa p = new Pessoa ("Carlos Eduardo", "Tsukamoto");

            Console.WriteLine($"Bem vindo {p.Nome} {p.SobreNome}");*/

            /*Pessoa tadeu = new Pessoa();*/

            /*tadeu.Nome = "José";*/

            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o seu sobrenome: ");
            string sobreNome = Console.ReadLine();

            Pessoa pessoa = new Pessoa(nome,sobreNome);

        }
    }
}

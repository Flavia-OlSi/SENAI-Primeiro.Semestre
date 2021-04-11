using System;
using Exercicio_1.classes;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan jogador = new MegaMan();

            Console.WriteLine($"Jogador 1 = {jogador.Correr()}");

            Zero jogador2 = new Zero();

            jogador2.Correr();
        }
    }
}

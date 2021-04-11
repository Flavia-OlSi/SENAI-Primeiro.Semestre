using System;

namespace Aula_41
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem objetoPersonagem1 = new Personagem();

            objetoPersonagem1.nome = "Mauricio";
            objetoPersonagem1.idade = 24;
            objetoPersonagem1.armadura = "Voadora";

            Personagem objetoPersonagem2 = new Personagem();

            objetoPersonagem2.nome = "Flávia";
            objetoPersonagem2.idade = 23;
            objetoPersonagem2.armadura = "Flash";

            Console.WriteLine($"Personagem 1 = {objetoPersonagem1.nome} - {objetoPersonagem1.Atacar()}");
            Console.WriteLine($"Personagem 2 = {objetoPersonagem2.nome} - {objetoPersonagem2.Defender()}");
        }
    }
}

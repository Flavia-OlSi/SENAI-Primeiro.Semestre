using System;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nomes = new string[15];
 
            for(var i = 0; i < 15; i++){
            Console.WriteLine($"Digite o {i+1}º nome: ");
            nomes[i] = Console.ReadLine();
            }
            Console.Clear();

            for(var i = 14; i >= 0; i--){
            Console.WriteLine(nomes[i]);
            }
        }
    }
}

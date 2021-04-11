using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Informe a nota: ");
            int nota = int.Parse(Console.ReadLine());

            while(nota > 10){
                Console.WriteLine("Valor inválido. Informe a nota: ");
                nota = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Valor válido.");
        }
    }
}

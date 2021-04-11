using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tabuada");

            for(var i = 1; i <= 10; i++){
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Tabuada do {i}"); 
                Console.ResetColor();
                for(var x = 1; x <= 10; x++){
                int resultado = i*x;
                Console.WriteLine($"{x} x {i} = {resultado}");
                }
            }
        }
    }
}

using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[10];
            int a = numeros[1];
            int b = numeros[1];

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º valor: ");
                numeros[i] = int.Parse(Console.ReadLine());
                if (numeros[i] > a)
                {
                    a = numeros[i];
                }

                if (numeros[i] < b)
                {
                    b = numeros[i];
                }
            }

            Console.WriteLine($"O maior número digitado foi {a} e o menor {b}");
        }
    }
}

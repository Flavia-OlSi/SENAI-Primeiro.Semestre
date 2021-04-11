using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int anterior = 0;
            int proximo = 1;
            int soma = 0;
            
            Console.WriteLine(anterior);
            Console.WriteLine(proximo);

            while(soma <= 500){
                
                soma = anterior + proximo;

                anterior = proximo;
                proximo = soma;
                
                Console.WriteLine(soma);
            }
        }
    }
}
﻿using System;

namespace Exibição_crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados
            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            //Processamento
            for(var i = 0; i <= num; i++){
                Console.WriteLine(i);
            }

        }
    }
}

using System;

namespace Aula_34
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados
            Console.WriteLine("Digite o número da tabuada que deseja: ");
            int num = int.Parse(Console.ReadLine());

            //Processamento
            for(var i = 0; i <= 10; i++){
              int conta = i*num;
              Console.WriteLine($"{num} x {i} = {conta}");
              }
        }
    }
}


using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade (anos): ");
            int idade = int.Parse(Console.ReadLine());
            
            //Processamento
            int meses = idade*12;
            int dias = meses*30;
            int horas = dias*24;
            int minutos = horas*60;

            //Exibir resultado
            Console.WriteLine("Quantidade de vida em: ");
            Console.WriteLine("Meses -> " +meses);
            Console.WriteLine("Dias -> " +dias);
            Console.WriteLine("Horas -> " +horas);
            Console.WriteLine("Minutos -> " +minutos);
        }
    }
}

using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados
            Console.WriteLine("Digite seu salario atual: ");
            float salAtual = float.Parse(Console.ReadLine());
            
            //Processamento
            if(salAtual < 500){
                float salNovo = ((salAtual*30)/100)+salAtual;
                Console.WriteLine($"Você recebeu um aumento de 30%, seu novo salario é {salNovo} reais.");
            }else{
                Console.WriteLine($"Você não recebeu aumento no salario, continua no valor de {salAtual} reais.");    
            }
        }
    }
}

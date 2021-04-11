using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados
            Console.WriteLine("Digite o nome do produto: ");
            string nomeP = Console.ReadLine();
            Console.WriteLine("Digite a quantidade adquirida: ");
            int quantidadeP = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitário do produto: ");
            float valorP = float.Parse(Console.ReadLine());

            //Processamento
            float total = quantidadeP * valorP;

            if(quantidadeP <= 5){
                float desconto = total - ((total*2)/100);
                Console.WriteLine($"O valor total da compra com o desconto é {desconto}.");
            }else if(quantidadeP > 5 && quantidadeP <= 10){
                float desconto = total - ((total*3)/100);
                Console.WriteLine($"O valor total da compra com o desconto é {desconto}.");;
            }else{
                float desconto = total - ((total*5)/100);
                Console.WriteLine($"O valor total da compra com o desconto é {desconto}.");
            }
           
        }
        
    }
}

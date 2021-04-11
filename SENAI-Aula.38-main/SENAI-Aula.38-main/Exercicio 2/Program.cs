using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            float preco; 

            Console.WriteLine("Digite a quantidade em litros de combustivel desejado: ");
            int litros = int.Parse(Console.ReadLine());

            Console.WriteLine("Selecione o tipode de combustivel: \nA - Ácool \nG - Gasolina");
            string combustivel = Console.ReadLine();
            Console.Clear();

            switch(combustivel)
            {
            case "A":
            preco = 4.90f;
            if(litros <= 20){
                int desconto = 3;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"O valor total da conta com desconto é de {DescontoCombustivel(preco, litros, desconto)}");
                Console.ResetColor();
            }else{
                int desconto = 5;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"O valor total da conta com desconto é de {DescontoCombustivel(preco, litros, desconto)}");
                Console.ResetColor();
            }
            break;

            case "G":
            preco = 5.30f;
            if(litros <= 20){
                int desconto = 4;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"O valor total da conta com desconto é de {DescontoCombustivel(preco, litros, desconto)}");
                Console.ResetColor();
            }else{
                int desconto = 6;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"O valor total da conta com desconto é de {DescontoCombustivel(preco, litros, desconto)}");
                Console.ResetColor();
            }
            break;
            }

            float DescontoCombustivel(float x, int y, int z){
                float valorDesconto = (x*y)-(((x*y)*3)/100);
                return valorDesconto;
            }
        }
    }
}

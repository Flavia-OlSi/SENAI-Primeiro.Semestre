using System;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];

            for(var x = 0; x < 10; x++){
                Console.WriteLine($"Digite da {x+1}ª pessoa: ");
                nomes[x] = Console.ReadLine();
            }

            Console.WriteLine("Digite o nome da pessoa que está procurando: ");
            string procurado = Console.ReadLine();

            int i = 0;
            int resultado = 0;
            while(i < 10){
                if(procurado == nomes[i]){
                    resultado = resultado + 1;
                }
                i++;
            }

            if(resultado != 0){
                    Console.WriteLine("ACHEI!");
                }else{
                    Console.WriteLine("Não achei");
                }
        }
    }
}

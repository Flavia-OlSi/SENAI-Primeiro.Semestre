using System;

namespace Aula_32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if(idade >= 18){
                Console.WriteLine("Você gostaria de participar do time de CS GO? - Sim ou Não");
                string resposta = Console.ReadLine();
                if(resposta == "Sim"){
                    Console.WriteLine("Compareça a secretaria - Falar com a SARA");
                }else{
                    Console.WriteLine("Blz! Passar bem.");
                }
            }else{
                Console.WriteLine("Você gostaria de participar do Time de lol? Sim ou Não");
                string resposta = Console.ReadLine();
                if(resposta == "Sim"){
                    Console.WriteLine("Compareça a secretaria - Falar com a Jucelino");
                }else{
                    Console.WriteLine("Muito Obrigada");
                }
            }
        }
    }
}

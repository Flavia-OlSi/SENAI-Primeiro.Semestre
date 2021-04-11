using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o nome do usuário: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a senha: ");
            string senha = Console.ReadLine();
            
            while(nome == senha){
                Console.WriteLine("Erro. A senha não pode ser igual ao nome do usuário.");

                Console.WriteLine("Digite o nome do usuário: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a senha: ");
                senha = Console.ReadLine();
            }
            Console.WriteLine("Cadastrado(a).");
        }
    }
}

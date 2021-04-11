using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Complete o cadastro.");

            //Nome
            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine();

            while(nome == null){
                Console.WriteLine("Nome inválido. Digite novamente: ");
                nome = Console.ReadLine();
            };

            //Idade
            Console.WriteLine("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            while(idade <= 0 && idade >= 150){
                Console.WriteLine("Idade inválida. Digite novamente: ");
                idade = int.Parse(Console.ReadLine());
            };
            
            //Salário
            Console.WriteLine("Digite o sálario: ");
            int salario = int.Parse(Console.ReadLine());

            while(salario <= 0){
                Console.WriteLine("Salário invalido. Digite novamente: ");
                salario = int.Parse(Console.ReadLine());
            };

            //Estado civil
            Console.WriteLine("Selecione o Estado civil: \nS - Solteiro(a) \nC - Casado(a) \nV - Viuvo(a) \nD - Divorciado(d)");
            string estadocivil = Console.ReadLine();
            
            while(nome == null){
            Console.WriteLine("Nome inválido. Selecione o Estado civil: \nS - Solteiro(a) \nC - Casado(a) \nV - Viuvo(a) \nD - Divorciado(d)");
            estadocivil = Console.ReadLine();
            };

            Console.WriteLine($"Cadastro finalizado. \nNome:{nome} \nIdade: {idade} \nSalário: {salario} \nEstado civil:{estadocivil}");
        }
    }
}

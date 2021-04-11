using System;
using Exercicio_1.classes; //Está chamando o arquivo Aluno

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            aluno1.nome = Console.ReadLine();

            Console.WriteLine("Digite o curso do aluno: ");
            aluno1.curso = Console.ReadLine();

            Console.WriteLine("Digite o RG do aluno: ");
            aluno1.rg = Console.ReadLine();

            Console.WriteLine("Digite a idade do aluno: ");
            aluno1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a média final do aluno: ");
            aluno1.mediaFinal = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da mensalidade do aluno: ");
            aluno1.valorMensalidade = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite se o aluno é bolsista: S/N ");
            string resposta = Console.ReadLine();
            if(resposta == "s"){
                aluno1.bolsista = true;
            }else{
                aluno1.bolsista = false;
            }

            //Menu
            int opcao =0;
            do{
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("[1] - Ver Média do aluno");
                Console.WriteLine("[2] - Ver Mensalidade do aluno");
                Console.WriteLine("[3] - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao){
                    case 1:
                        Console.WriteLine($"A média final do aluno {aluno1.nome} = {aluno1.VerMediaAluno()}");
                        break;
                    case 2:
                        Console.WriteLine($"O valor da mensalidade do aluno fica em: {aluno1.VerMensalidade()}");
                        break;
                    case 0:
                        Console.WriteLine("Obrigada por acessar!");
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                 }

            }while(opcao != 0);



        }
    }
}

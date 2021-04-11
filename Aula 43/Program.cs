using System;

using Aula_43.classes;

namespace Aula_43
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escolha: \n1 - Pessoa Física \n2 - Pessoa Juridica");
            int escolha = int.Parse(Console.ReadLine());
            Console.Clear();

            if(escolha == 1){
                //Instanciamos nossa subclasse
                PessoaFisica pf = new PessoaFisica();

                //Atribuimos um valor para a propriedade disponível na superclasse
                Console.WriteLine("Digite seu nome: ");
                pf.nome = Console.ReadLine(); 
                Console.Clear();
                Console.WriteLine(pf.DarBoasVindas(pf.nome));

                Console.WriteLine("Digite seu RG: ");
                pf.rg = Console.ReadLine();

                Console.WriteLine("Digite seu CPF: ");
                pf.cpf = Console.ReadLine();
                
                if(pf.ValidarCPF(pf.cpf) == true){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"CPF {pf.cpf} valido");
                    Console.ResetColor();
                }else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"CPF {pf.cpf} invalido");
                    Console.ResetColor();
                }
                
            }else if(escolha == 2){
                //Instanciamos nossa subclasse
                PessoaJuridica pj = new PessoaJuridica();

                //Atribuimos um valor para a propriedade disponível na superclasse
                Console.WriteLine("Digite o nome da empresa: ");
                pj.nome = Console.ReadLine(); 
                Console.Clear();
                Console.WriteLine(pj.DarBoasVindas(pj.nome));

                Console.WriteLine("Digite a inscrição estadual: ");
                pj.inscricaoEstadual = Console.ReadLine();

                Console.WriteLine("Digite o CNPJ: ");
                pj.cnpj = Console.ReadLine();
                if(pj.ValidarCNPJ(pj.cnpj) == true){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"CNPJ {pj.cnpj} valido");
                    Console.ResetColor();
                }else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"CNPJ {pj.cnpj} invalido");
                    Console.ResetColor();
                }
            }else{
                Console.WriteLine("Opção invalida!");
            }
            
        }
    }
}

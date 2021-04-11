using System;

namespace Aula_40
{
    class Program
   using System;

namespace Aula_40
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            string[] nome = new string[10];
            float[] preco = new float[10];
            bool[] promocao = new bool[10];

            Console.WriteLine(MostrarMenu());
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                do
                { 
                Console.WriteLine(CadastrarProduto());
                i = i + 1;
                Console.Clear();
                }while (i < 10);

            }else if(opcao == 2){
                ListarProdutos();
            }

            // Frunções
            string MostrarMenu()
            {
                return "MENU \n1 - Cadastrar produto \n2 - Listar produto";
            }

            string CadastrarProduto()
            {
                Console.WriteLine($"Cadastro do {i + 1}º produto");
                //Nome do produto
                Console.WriteLine("Digite o nome do produto: ");
                nome[i] = Console.ReadLine();
                //Preço do produto
                Console.WriteLine("Digite o preço do produto: ");
                preco[i] = float.Parse(Console.ReadLine());
                //Promoção
                Console.WriteLine("O produto está em promoção? S - Sim / N - Não");
                string escolha = Console.ReadLine();
                if (escolha == "S" || escolha == "s")
                {
                    promocao[i] = true;
                }
                else
                {
                    promocao[i] = false;
                }
                return "Produtos cadastrados";
            }

            void ListarProdutos()
            {
                for(var i = 0; i < 10; i++){
                    Console.WriteLine($"Produto {i+1}º: {nome[i]} | {preco[i]} | {promocao[i]}");
                }   
            }
        }
    }
}


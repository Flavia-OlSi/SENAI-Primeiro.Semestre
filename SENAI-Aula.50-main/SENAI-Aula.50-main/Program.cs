using System;
using System.Collections.Generic;
using Aula_50.classes;

namespace Aula_50
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<string> nomes = new List<string>();
            nomes.Add("Carlos");
            nomes.Add("José");
            nomes.Add("Ronaldo");
            nomes.Add("Chintia");
            nomes.Add("Maria");

            
            //Contains é utilizado para identificar o item na lista
            bool resposta = nomes.Contains("Dudu");

            if(resposta == true){
            Console.WriteLine("Nome encontrado");
            }else{
                Console.WriteLine("Nome não encontrado");
            }

            //Count é utilizado para contar quantos itens temos na lista
            Console.WriteLine(nomes.Count);


            //Insert é utilizado para inserir a informação solicitada em tal local
            for(var i = 0; i < nomes.Count; i++ ){
                if(nomes[i] == "Ronaldo"){
                    nomes.Insert(i,"Ronaldinho");
                }
            }

            //Remove é utilizado para remover algo da lista
            nomes.Remove("Ronaldo");

            //Sort é  tulizado para ordenar a lista
            nomes.Sort();*/

            List<Produto> produtos = new List<Produto>();

            Produto cafe = new Produto(2, "Café pequeno", 2.5f);

            produtos.Add(new Produto(1, "Pão na chapa", 5.0f));
           produtos.Add(cafe);
           produtos.Add(new Produto(3, "Coxinha", 5.0f));
           produtos.Add(new Produto(4, "refrigerante", 6.8f));



            foreach (Produto item in produtos)
            {
                    Console.WriteLine($"item codigo{item.Codigo} Nome {item.Nome} Preço {item.Preco}");
            }
            




        }
    }
}

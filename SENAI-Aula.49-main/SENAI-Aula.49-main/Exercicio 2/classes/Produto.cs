using System;

namespace Exercicio_2.classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }

        //Método cosntrutor
        public Produto()
        {
           
        }

        public Produto(int valor)
        {
            Codigo = valor;
        }

        //Explicação de método contrutor e convencional
        /*public string ExibeTexto(){
            return "Esse metodo exibe o texto Carlos";
        }

        public string ExibeTexto(string nome){
            return $"Esse metodo exibe o texto {nome}";*/

        public Produto(int codigo, string nome, string descricao, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Estoque = estoque;
        }

    }
}

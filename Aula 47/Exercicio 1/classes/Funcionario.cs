using System;

namespace Aula_47.classes

{
    public class Funcionario
    {
        
        public string [] lista = {"Paulo", "Tsuka", "Priscila", "Fernanda"};

        public void Mostrar(){
            //Imprimimos todos os dados que estão no array
            foreach(var item in lista){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item);
                Console.ResetColor();
            }
        }

        public void Mostrar(int indice){
            // Mostramos apenas o dado que está no índice do array
            Console.ForegroundColor = ConsoleColor.Blue;
                if(indice < lista.Length){Console.WriteLine(lista[indice]);}
            
                Console.ResetColor();
        }

        public void Mostrar(string busca){
            //Fazemos uma busca no array para verificar se os textos coincidem
            foreach(var item in lista){
                Console.ForegroundColor = ConsoleColor.Yellow;

                if(item == busca){Console.WriteLine("Resultado da busca: " + item);
                }

                Console.ResetColor();
            }
        }

    }
}
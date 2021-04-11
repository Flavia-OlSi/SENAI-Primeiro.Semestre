using System;

namespace Exercicio_2.classes
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;

        public string Ligar(){
            return ("Celular está ligado.");
        }
        public string Desligar(){
            return ("Celular está desligado.");
        }
        public string FazerLigacao(){
            Console.WriteLine("Digite o número do telefone que deseja ligar: ");
            string numero = Console.ReadLine();
            Console.Clear();
            return ($"Você está fazendo uma ligação para o número {numero}");
        }
        public string EnviarMensagem(){
            Console.WriteLine("Digite o número do telefone que deseja mandar mensagem: ");
            string numero = Console.ReadLine();
            Console.WriteLine("Digite a mensagem: ");
            string mensagem = Console.ReadLine();
            return ($"Você enviou uma mensagem para o número {numero}");
        }
    }
}
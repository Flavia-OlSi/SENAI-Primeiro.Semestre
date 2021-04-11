using System;

namespace abstracao.classes
{
    public abstract class Pagamento
    {
        //Atributos
        private DateTime data;

        public DateTime Data{
            get{return DateTime.Now;}
        }
        
        protected float valor;
        public float Valor{
            set{valor = value;}
            get{return valor;}
        }
        

        //Métodos
        public string Cancelar(){
            Console.WriteLine("Deseja cancelar o pagamento? \nS - Sim \nN - Não");
            string afirmar = Console.ReadLine();
            if(afirmar == "S"){
            return "Pagamento cancelado";
            }else{
                return "Pagamento não foi cancelado";
            }
        }

        //Obrigatório
    

        
    }
}
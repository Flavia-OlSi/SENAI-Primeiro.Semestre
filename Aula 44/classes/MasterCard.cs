namespace Aula_44.classes
{
    public class MasterCard : Cartao
    {
        
        //Atributos
        private int parcelas;

        //Get e Set
        public int Parcelas{
            get {return parcelas;} //Acesso a leitura
            set {parcelas = value;} // Acesso a gravação
        }

        //Métodos
        public string ComprarComDesconto(){
            return "";
        }

    }
}
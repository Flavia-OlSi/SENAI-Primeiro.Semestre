namespace Aula_43.classes
{
    public class PessoaJuridica : Pessoa
    {
        
        public string cnpj;

        public string inscricaoEstadual;

        public bool ValidarCNPJ(string documento){

                if(documento != ""){
                    return true;
                }
                return false;
        }
    }
}
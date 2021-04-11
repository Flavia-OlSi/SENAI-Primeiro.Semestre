using Aula_52.Classes;

namespace Aula_52.Classes
{
    public interface ICarrinho
    {
        //CRUD
        //Create - Cadastrar
        void Cadastrar(Produto produto);

        //Read - Ler
        void Listar();

        //Update - Alterar
        void Alterar(int cod, Produto produto);

        //Delete - Deletar
        void Deletar(Produto produto);
    }
}
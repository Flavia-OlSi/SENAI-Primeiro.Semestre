using System.Collections.Generic;
using Aula_56.Models;

namespace Aula_56.Interfaces
{
    public interface IEquipe
    {
        //Métodos de CRUD - Contrato
        void Create(Equipe e);
        List<Equipe> ReadAll();
        void Update(Equipe e);
        void Delete(int id);
    }
}
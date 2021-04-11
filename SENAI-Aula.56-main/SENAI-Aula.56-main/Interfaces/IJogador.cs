using System.Collections.Generic;
using Aula_56.Models;

namespace Aula_56.Interfaces
{
    public interface IJogador
    {
         
        //CRUD
        //Create
        void Create(Jogador j);
        //Read
        List<Jogador> ReadAll();
        //Update
        void Update(Jogador j);
        //Delete
        void Delete(int id);

    }
}
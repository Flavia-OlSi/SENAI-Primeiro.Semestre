using System;
using Aula_47.classes;

namespace Aula_47
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos nossa classe Funcionario
            Funcionario fun = new Funcionario();

            fun.Mostrar();
            fun.Mostrar("Tsuka");
            fun.Mostrar(3);

            Console.Beep();

        }
    }
}

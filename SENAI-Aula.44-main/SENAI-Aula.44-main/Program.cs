using System;
using Aula_44.classes;

namespace Aula_44
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();

            m.Parcelas = 12;

            Console.WriteLine(m.Bandeira);
        }
    }
}

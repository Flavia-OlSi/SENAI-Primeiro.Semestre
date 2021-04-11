using System;

namespace Exercicio_2.classes
{
    public abstract class Taxa
    {
        
        private float valor;

        public virtual void ValeRefeicao(){
            Console.WriteLine($"A taxa ser paga é de 5%");
        }
    }
}
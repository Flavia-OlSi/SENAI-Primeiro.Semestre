using System;
namespace Exercicio_2.classes
{
    public class Professor : Taxa
    {
        
        public string turma;

        public override void ValeRefeicao(){
            base.ValeRefeicao(); //Puxa o que tem virtual
            Console.WriteLine($"A taxa do professor é de 10%");
        }

    }
}
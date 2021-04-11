using System;

namespace Calculadora_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir a operação
            // Pedir o 1º número
            // Pedir o 2º número

            Console.WriteLine("Digite a operação que deseja fazer /nSoma, Sobtracao, Multiplicacao, Divisao");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o 1º número");
            float num1 = float.Parse(Console.ReadLine());

            // ALT   + SHIFT + SETA PARA BAIXO  
            Console.WriteLine("Digite o 2º número");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0;
            // IF / ELSE 
            // if(operacao == "Soma"){
            // }else if(operacao == "Sobtracao"){
            // }else if(operacao == "Multiplicacao"){
            // }else if(operacao == "Divisao"){
            // }else{
            //  Console.WriteLine("Operação inválida");
            // }
            // Para comentar ou descomentar use CTRL + ;

            // Switch case
            switch(operacao){

                case "Soma":
                    resultado = num1+num2;
                    break;

                case "Subtracao":
                    resultado = num1-num2;
                    break;
                
                case "Multiplicacao":
                    resultado = num1*num2;
                    break;
                
                case "Divisao":
                    resultado = num1/num2;
                    break;
                
                default:
                    Console.WriteLine("Operação inválida");
                    break;


            }

            // Concatenação
            //Console.WriteLine("Calculo: " +num1+" e "+num2+"Resultado: "+resultado);

            // Interpolação
            Console.WriteLine($"Calculo: {num1} e {num2} = Resultado: {resultado}");

        }
    }
}

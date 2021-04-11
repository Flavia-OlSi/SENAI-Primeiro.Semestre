using System;
using abstracao.classes;

namespace abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o valor da compra: ");
            float valorDaCompra = float.Parse(Console.ReadLine());

            Console.WriteLine("Selecione o tipo de pagamento: \n1 - Boleto \n2 - Cartão"); 
            int opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {
                //Boleto
                case 1:
                        Boleto boleto = new Boleto();
                        boleto.Valor = valorDaCompra;
                        boleto.Registrar(boleto.Valor, boleto.Data, boleto.CodigoDeBarras);
                    break;

                //Cartão
                case 2:
                    Console.WriteLine("Selecione o tipo de pagamento no cartão: \n1 - Crédito \n2 - Débito"); 
                    int tipoCartao = int.Parse(Console.ReadLine());

                    

                    switch(tipoCartao){
                        
                        case 1:
                        //Credito
                        Credito credito = new Credito();
                        credito.numero = "12334.123123.123123";
                        credito.bandeira = "MasterCard";
                        credito.cvv = "123";
                        credito.titular = "Flávia de Oliveira";
                        credito.Pagar(valorDaCompra);
                            break;


                        default:

                            break;

                    }

                    break;
                  
            }
            
            

        
            
            
        }
    }
}

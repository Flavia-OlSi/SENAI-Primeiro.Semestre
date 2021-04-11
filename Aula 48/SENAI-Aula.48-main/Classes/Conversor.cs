namespace Aula_48.Classes
{
    public class Conversor
    {
        //Conversor Dolar 
        private static float cotacaoDolar = 5.07f;

        public static float RealParaDolar(float valorRS){
            return valorRS / cotacaoDolar;
        }
        public static float DolarParaReal(float valorDolar){
            return valorDolar * cotacaoDolar;
        }


        //Converso Euro
        private static float cotacaoEuro = 6.18f;
        public static float RealParaEuro(float valorRS){
            return valorRS / cotacaoEuro;
        }
        public static float EuroParaReal(float valorEuro){
            return valorEuro * cotacaoEuro;
        }




    }
}
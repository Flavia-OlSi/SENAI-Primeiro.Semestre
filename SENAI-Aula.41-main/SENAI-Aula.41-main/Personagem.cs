namespace Aula_41
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;

        public string Atacar(){
            return "Ataque de fogo!";
        }

        public string Defender(){
            return "Não foi dessa vez";
        }

    }
}
using System;

namespace Adapter
{
    public class RoboInimigo
    {
        private Random _gerador = new Random();

        public void EsmagarComMaos()
        {
            int danoAtaque = _gerador.Next(10) + 1;
            Console.WriteLine($"o robo inimigo causou {danoAtaque} de dano com o ataque de esmagar com as maos");
        }

        public void AndarFrente()
        {
            int movimento = _gerador.Next(5) + 1;
            Console.WriteLine($"o robo inimigo andou {movimento} para frente");
        }

        public void ReagirContraHumando(string piloto)
        {
            Console.WriteLine($"o robo inimigo vai contra {piloto}");
        }
    }
}
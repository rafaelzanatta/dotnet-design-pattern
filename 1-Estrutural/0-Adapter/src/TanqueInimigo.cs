using System;

namespace Adapter
{
    public class TanqueInimigo : IAtaqueInimigo
    {
        private Random _gerador = new Random();

        public void ArmaFogo()
        {
            int danoAtaque = _gerador.Next(10) + 1;
            Console.WriteLine($"tanque inimigo fez {danoAtaque} de dano");
        }

        public void Movimenta()
        {
            int movimento = _gerador.Next(5) + 1;
            Console.WriteLine($"tanque inimigo andou {movimento} passos");
        }

        public void Pilotar(string piloto)
        {
            Console.WriteLine($"{piloto} esta no comando do tanque agora");
        }
    }
}
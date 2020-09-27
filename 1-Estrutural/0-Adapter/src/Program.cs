using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            TanqueInimigo tanque = new TanqueInimigo();
            RoboInimigo robo = new RoboInimigo();

            IAtaqueInimigo roboAdapter = new RoboInimigoAdapter(robo);

            Console.WriteLine(" ===== ROBO =====");
            robo.ReagirContraHumando("THIAGO NEVES");
            robo.AndarFrente();
            robo.EsmagarComMaos();

            Console.WriteLine(" ===== TANQUE =====");
            tanque.Pilotar("GERO");
            tanque.Movimenta();
            tanque.ArmaFogo();

            Console.WriteLine(" ===== ROBO ADAPTADO =====");
            roboAdapter.Pilotar("THIAGO NEVES ADAPTADO");
            roboAdapter.Movimenta();
            tanque.ArmaFogo();


            Console.ReadKey();
        }
    }
}

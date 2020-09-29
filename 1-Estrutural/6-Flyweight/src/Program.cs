using System;

namespace Flyweigth
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaFlyweight fabrica = new FabricaFlyweight();

            string cor = string.Empty;
            Tartaruga tartaruga;

            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("qual tartaruga enviar para tela:");
                cor = Console.ReadLine();

                tartaruga = fabrica.GetTartaruga(cor);
                tartaruga.Mostra(cor);

                Console.WriteLine();
                Console.WriteLine("---------------------");
            }
        }
    }
}

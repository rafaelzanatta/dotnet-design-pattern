using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabricante fabricante = new Fabricante();
            ICelular celularBuilder = null;

            celularBuilder = new AndroidBuilder();
            fabricante.Construtor(celularBuilder);
            Console.WriteLine($"Um celular foi contruido: {celularBuilder.Celular.Nome}");

            Console.WriteLine();

            celularBuilder = new IphoneBuilder();
            fabricante.Construtor(celularBuilder);
            Console.WriteLine($"Um celular foi contruido: {celularBuilder.Celular.Nome}");


            Console.ReadKey();
        }
    }
}

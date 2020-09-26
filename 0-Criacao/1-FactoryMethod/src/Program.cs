using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod fm = new FactoryMethod();

            Console.WriteLine("0 - liu kang\n1 - scorpion\n2 - sub-zero");
            Console.WriteLine("");

            Console.WriteLine("escolha o id do personagem: ");
            var escolha = int.Parse(Console.ReadLine());

            var personagem = fm.EscolherPersonagem((PersonagemList)escolha);

            Console.WriteLine();
            Console.WriteLine($"voce vai jogar com: {personagem.Escolhido()}");

            Console.ReadKey();
        }
    }
}

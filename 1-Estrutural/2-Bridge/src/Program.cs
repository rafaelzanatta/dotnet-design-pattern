using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartTv smart = new SmartTv();
            Console.WriteLine("selecione um canal");
            Console.WriteLine("1 - filmes\n2 - documentarios\n3 - culinaria");
            
            var input = Console.ReadKey();

            switch(input.KeyChar)
            {
                case '1':
                    smart.CanalAtual = new Filme();
                    break;
                case '2':
                    smart.CanalAtual = new Documentario();
                    break;
                case '3':
                    smart.CanalAtual = new Culinaria();
                    break;
            }

            Console.WriteLine();
            smart.ExibeCanalSintonizado();
            smart.PlayTv();

            Console.ReadKey();
        }
    }
}

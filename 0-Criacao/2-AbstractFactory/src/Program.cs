using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = ExecutaAbstractFactory.MontarCarro("luxo");
            Carro c2 = ExecutaAbstractFactory.MontarCarro("popular");
        }
    }
}

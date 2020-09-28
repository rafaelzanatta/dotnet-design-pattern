using System;

namespace Facade
{
    public class Facade
    {
        private SubSistemaUm um = new SubSistemaUm();
        private SubSistemaDois dois = new SubSistemaDois();
        private SubSistemaTres tres = new SubSistemaTres();

        public Facade()
        {
            um = new SubSistemaUm();
            dois = new SubSistemaDois();
            tres = new SubSistemaTres();
        }

        public void MetodoA()
        {
            Console.WriteLine("\nmetodo A ------");
            dois.MetodoDois();
            tres.MetodoTres();
        }

        public void MetodoB()
        {
            Console.WriteLine("\nmetodo B ------");
            um.MetodoUm();
            tres.MetodoTres();
        }
    }
}
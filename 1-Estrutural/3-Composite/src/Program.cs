using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("ROOT");
            root.Adicionar(new Folha("folha A"));
            root.Adicionar(new Folha("folha B"));

            Composite comp = new Composite("COMPOSITE X");
            comp.Adicionar(new Folha("folha XA"));
            comp.Adicionar(new Folha("folha XB"));

            root.Adicionar(comp);
            root.Adicionar(new Folha("folha C"));

            Folha folha = new Folha("folha D");
            root.Adicionar(folha);
            root.Remover(folha);

            root.Mostrar(1);

            Console.ReadKey(); 
        }
    }
}

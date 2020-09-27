using System;

namespace Composite
{
    public class Folha : Componente
    {
        public Folha(string nome) : base(nome)
        {
            
        }

        public override void Adicionar(Componente c)
        {
            Console.WriteLine("nao e possivel adicionar a folha");
        }

        public override void Remover(Componente c)
        {
            Console.WriteLine("nao e possivel remover a folha");
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new String('-', profundidade) + Nome);
        }
    }
}
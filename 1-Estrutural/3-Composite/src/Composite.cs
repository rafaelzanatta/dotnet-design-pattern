using System;
using System.Collections.Generic;

namespace Composite
{
    public class Composite : Componente
    {
        private List<Componente> _filhos = new List<Componente>();

        public Composite(string nome) : base(nome)
        {
            
        }

        public override void Adicionar(Componente c)
        {
            _filhos.Add(c);
        }

        public override void Remover(Componente c)
        {
            _filhos.Remove(c);
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new String('-', profundidade) + Nome);
            foreach(Componente item in _filhos)
            {
                item.Mostrar(profundidade + 2);
            }
        }
    }
}
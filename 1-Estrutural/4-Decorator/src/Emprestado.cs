using System;
using System.Collections.Generic;

namespace Decorator
{
    public class Emprestado : Decorator
    {
        protected List<string> emprestados = new List<string>();

        public Emprestado(ItemBiblioteca item) : base(item)
        {

        }

        public void EmprestarItem(string nome)
        {
            emprestados.Add(nome);
            itemBiblioteca.NumeroCopias--;
        }

        public void DevolverItem(string nome)
        {
            emprestados.Remove(nome);
            itemBiblioteca.NumeroCopias++;
        }

        public override void Exibe()
        {
            base.Exibe();
            foreach(string item in emprestados)
            {
                Console.WriteLine($"emprestado: {item}");
            }
        }
    }
}
using System;

namespace Decorator
{
    public class Decorator : ItemBiblioteca
    {
        protected ItemBiblioteca itemBiblioteca;

        public Decorator(ItemBiblioteca item)
        {
            itemBiblioteca = item;
        }

        public override void Exibe()
        {
            itemBiblioteca.Exibe();
        }
    }
}
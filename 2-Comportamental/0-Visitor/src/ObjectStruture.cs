using System.Collections.Generic;

namespace Visitor
{
    public class ObjectStruture
    {
        private List<Element> _elementos = new List<Element>();

        public void Anexar(Element elemento)
        {
            _elementos.Add(elemento);
        }

        public void Desanexar(Element elemento)
        {
            _elementos.Remove(elemento);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element elemento in _elementos)
            {
                elemento.Accept(visitor);
            }
        }
    }
}
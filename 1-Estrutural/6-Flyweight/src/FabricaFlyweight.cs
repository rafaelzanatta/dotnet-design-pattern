using System.Collections.Generic;

namespace Flyweigth
{
    public class FabricaFlyweight
    {
        private Dictionary<string, Tartaruga> listaTartarugas = new Dictionary<string, Tartaruga>();

        public Tartaruga GetTartaruga(string cor)
        {
            Tartaruga t = null;

            if(listaTartarugas.ContainsKey(cor))
            {
                t = listaTartarugas[cor];
            }
            else
            {
                switch (cor)
                {
                    case "azul":     t = new Azul();     break;
                    case "verde":    t = new Verde();    break;
                    case "vermelha": t = new Vermelha(); break;
                    case "laranja":  t = new Laranja();  break;
                }
                listaTartarugas.Add(cor, t);
            }

            return t;
        }
    }
}
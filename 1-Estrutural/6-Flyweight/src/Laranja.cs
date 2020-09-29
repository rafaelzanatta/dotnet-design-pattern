using System;

namespace Flyweigth
{
    public class Laranja : Tartaruga
    {
        public Laranja()
        {
            Condicao = "tartaruga dentro do casco, ";
            Acao = "rodando no chao - ";
        }

        public override void Mostra(string cor)
        {
            Cor = cor;
            Console.WriteLine(Condicao + Acao + cor.ToUpper());
        }
    }
}
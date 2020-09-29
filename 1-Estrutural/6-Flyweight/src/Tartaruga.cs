namespace Flyweigth
{
    public abstract class Tartaruga
    {
        protected string Condicao;
        protected string Protecao;
        protected string Acao;
        public string Cor { get; set; }

        public abstract void Mostra(string cor); 
    }
}
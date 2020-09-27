namespace Bridge
{
    public class Filme : ICanal
    {
        public string Canal()
        {
            return "sintonizado no canal de filmes";
        }

        public string Status()
        {
            return "voce esta assintindo - os vingadores";
        }
    }
}
namespace sigleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogador1 = BolaSingleton.GetIntancia;
            jogador1.Mensagem("jogador 1 rouba a bola");

            var jogador2 = BolaSingleton.GetIntancia;
            jogador2.Mensagem("jogador 2 lanca bola para o atacante");

            var jogador3 = BolaSingleton.GetIntancia;
            jogador3.Mensagem("jogador 3 finaliza em direcao ao gol");
        }
    }
}

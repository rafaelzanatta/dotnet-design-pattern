namespace Adapter
{
    public class RoboInimigoAdapter : IAtaqueInimigo
    {
        private RoboInimigo _robo;

        public RoboInimigoAdapter(RoboInimigo robo)
        {
            _robo = robo;
        }

        public void ArmaFogo()
        {
            _robo.EsmagarComMaos();
        }

        public void Movimenta()
        {
            _robo.AndarFrente();
        }

        public void Pilotar(string piloto)
        {
            _robo.ReagirContraHumando(piloto);
        }
    }
}
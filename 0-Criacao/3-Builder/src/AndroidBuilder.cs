namespace Builder
{
    public class AndroidBuilder : ICelular
    {
        public Celular Celular
        {
            get { return _celular; }
        }

        private Celular _celular;

        public AndroidBuilder()
        {
            _celular = new Celular("Samsung S20");
        }

        public void BuildBateria()
        {
            _celular.Bateria = "4000 mAh";
        }

        public void BuildCamera()
        {
            _celular.Camera = "64 MP";
        }

        public void BuildSistema()
        {
            _celular.SistemaOperacional = "Android 10";
        }

        public void BuildTela()
        {
            _celular.Tela = "6.2";
        }
    }
}

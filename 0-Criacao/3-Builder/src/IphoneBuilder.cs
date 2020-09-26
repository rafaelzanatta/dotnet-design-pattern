namespace Builder
{
    public class IphoneBuilder : ICelular
    {
        public Celular Celular
        {
            get { return _celular; }
        }

        private Celular _celular;

        public IphoneBuilder()
        {
            _celular = new Celular("Iphone 11");    
        }

        public void BuildBateria()
        {
            _celular.Bateria = "3046 mAh";
        }

        public void BuildCamera()
        {
            _celular.Camera = "12 MP";
        }

        public void BuildSistema()
        {
            _celular.SistemaOperacional = "IOS 13";
        }

        public void BuildTela()
        {
            _celular.Tela = "6.1";
        }
    }
}
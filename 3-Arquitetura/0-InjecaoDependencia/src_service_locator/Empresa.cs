namespace InjecaoDependencia
{
    public class Empresa : IObjetoEndereco
    {
        public int Codigo { get; set; }
        public string RazaoSocial { get; set; }
        private IObjetoEndereco Endereco { get; set; }

        public Empresa()
        {
            Endereco = Localizador.GetEndereco();
        }
    }
}
using System;

namespace InjecaoDependencia
{
    public class Empresa : IObjetoEnderecoIJ
    {
        public int Codigo { get; set; }
        public string RazaoSocial { get; set; }
        private IObjetoEndereco Endereco { get; set; }

        public Empresa()
        {
            
        }

        public void SetEndereco(IObjetoEndereco obj)
        {
            Endereco = obj;
        }

        public void GetEndereco()
        {
            Console.WriteLine(Endereco);
        }
    }
}
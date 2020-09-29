using System;

namespace InjecaoDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            EnderecoA endA = new EnderecoA();
            endA.Rua = "rua dos bobos";
            endA.Numero = 0;

            EnderecoB endB = new EnderecoB();
            endB.Cidade = "porto alegre";
            endB.Uf = "RS";

            Empresa empresa1 = new Empresa();
            empresa1.SetEndereco(endA);
            empresa1.GetEndereco();

            Empresa empresa2 = new Empresa();
            empresa2.SetEndereco(endB);
            empresa2.GetEndereco();
        }
    }
}

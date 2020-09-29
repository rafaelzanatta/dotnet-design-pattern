using System;

namespace Observer
{
    public class ObservadorConcreto : Observador
    {
        private string _nome;
        private string _estadoObservador;
        private AssuntoConcreto _assunto;

        public ObservadorConcreto(AssuntoConcreto assunto, string nome)
        {
            _assunto = assunto;
            _nome = nome;
        }

        public override void Update()
        {
            _estadoObservador = _assunto.EstadoAssunto;
            Console.WriteLine($"observador {_nome} seu novo estado e: {_estadoObservador}");
        }

        public AssuntoConcreto Assunto { get; set; }
    }
}
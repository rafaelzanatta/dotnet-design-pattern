using System;

namespace Mediator
{
    public class ColegaConcreto2 : Colega
    {
        public ColegaConcreto2(Mediator mediator) : base(mediator)
        {

        }

        public void Enviar(string mensagem)
        {
            mediator.Enviar(mensagem, this);
        }

        public void Notificar(string mensagem)
        {
            Console.WriteLine($"mensagem do colega 2: {mensagem}");
        }
    }
}
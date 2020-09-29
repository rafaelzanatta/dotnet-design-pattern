using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            AssuntoConcreto s = new AssuntoConcreto();
            s.Anexar(new ObservadorConcreto(s, "a"));
            s.Anexar(new ObservadorConcreto(s, "b"));
            s.Anexar(new ObservadorConcreto(s, "c"));

            s.EstadoAssunto = "hehehe";
            s.Notificar();

            Console.ReadKey();
        }
    }
}

using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "on";

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "off";

            o.SetMemento(c.Memento);

            Console.ReadKey();
        }
    }
}

using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "item A";
            a[1] = "item B";
            a[2] = "item C";
            a[3] = "item D";

            Iterator i = a.CreateIterator();

            Console.WriteLine("iteragindo com a colecao:");

            object item = i.First();
            while(item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Console.ReadKey();
        }
    }
}

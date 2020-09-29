using System;

namespace ChainResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler h1 = new ConcreteHander1();
            Handler h2 = new ConcreteHander2();
            Handler h3 = new ConcreteHander3();

            h1.SetSucessor(h2);
            h2.SetSucessor(h3);

            int[] requests = {2, 5, 24, 22, 18,3, 27, 20};

            foreach (int request in requests)
            {
                h1.HandlerRequest(request);
            }

            Console.ReadKey();
        }
    }
}

using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass abA = new ConcreteClassA();
            abA.TemplateMethod();


            AbstractClass abB = new ConcreteClassB();
            abB.TemplateMethod();

            Console.ReadKey();
        }
    }
}

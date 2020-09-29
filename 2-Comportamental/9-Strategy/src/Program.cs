using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList studants = new SortedList();
            studants.Add("geromel");
            studants.Add("kanneman");
            studants.Add("maicon");
            studants.Add("cavani");

            studants.SetSortStrategy(new QuickSort());
            studants.Sort();

            studants.SetSortStrategy(new ShellSort());
            studants.Sort();

            studants.SetSortStrategy(new MergeSort());
            studants.Sort();

            Console.ReadKey();
        }
    }
}

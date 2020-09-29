using System;
using System.Collections.Generic;

namespace Strategy
{
    public class MergeSort : ShellSort
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("merge sorted list");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            int max=list.Head.data;
            int min=list.Head.data;
            int sum = 0;
            list.ForEvery(item => sum += item);
            list.ForEvery(item => { if (max < item) max = item; });
            list.ForEvery(item => { if (min > item) min = item; });

            Console.WriteLine($"list max is {max}");
            Console.WriteLine($"list min is {min}");
            Console.WriteLine($"list sum is {sum}");
        }
    }
}

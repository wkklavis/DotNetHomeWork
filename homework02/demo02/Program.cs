using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max = GetMax(array);
            int min = GetMin(array);
            double avg = GetAvg(array);
            Console.WriteLine($"max={max}");
            Console.WriteLine($"min={min}");
            Console.WriteLine($"avg={avg}");
        }

        private static double GetAvg(int[] array)
        {
            if (array == null) return 0;

            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum/array.Length;
        }

        private static int GetMin(int[] array)
        {
            if (array == null) return 0;
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i]) min = array[i];
            }
            return min;
        }

        private static int GetMax(int[] array)
        {
            if (array == null) return 0;
            int max = array[0];
            for(int i=1; i < array.Length; i++)
            {
                if (max < array[i]) max = array[i];
            }
            return max;
        }
    }
}

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
            int num =Int32.Parse( Console.ReadLine());
            GetPrimeNumber(num);
        }

        private static void GetPrimeNumber(int num)
        {
            if (num <= 1) return;
            while (num % 2 == 0) { num /= 2; Console.Write("2 "); }//使得num为奇数

            for(int i = 3; i < Math.Sqrt(num); i+=2) 
            { 
                if (num % i == 0) { num /= i;Console.Write($"{i} "); }//获取奇数因子
            }

            if (num > 2) Console.Write($"{num} ");//此时num如果不为1，则说明本身即是一个质数


        }
    }
}

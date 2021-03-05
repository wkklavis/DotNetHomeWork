using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[101];
            for(int i = 2; i <= 100; i++)//
            {
                array[i] = 1;
            }
            Handle(array);
            for (int i = 2; i <= 100; i++)//
            {
                if (array[i] == 1) Console.Write($"{i} ");
            }
        }

        private static void Handle(int[] array)
        {
            //throw new NotImplementedException();
            for(int div = 2; div <= 100; div++)//除数遍历
            {
                if (array[div] == 0) continue;
                //处理数组中的数
                for(int i = 2; i <= 100; i++)
                {
                    if (array[i] == 0) continue;
                    if (i % div == 0 && i != div) array[i] = 0;//处理div的倍数

                }
            }
        }
    }
}

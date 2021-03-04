using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    class Program
    {
        static void Main(string[] args)
        {   //获取输入
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            char operation = Console.ReadKey().KeyChar;

            double result=0;
            Console.WriteLine();
            //转换运算符，计算结果
            switch (operation)
            {
                case '+': { result = num1 + num2; break; }
                case '-': { result = num1 - num2; break; }
                case '*': { result = num1 * num2; break; }
                case '/': { result = num1 / num2; break; }
                default: { Console.WriteLine("运算符有误");break; }
            }
            Console.WriteLine($"{num1} {operation} {num2} = {result}");

        }
    }
}

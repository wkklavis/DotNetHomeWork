using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 3, 4 }, 
                              { 5, 1, 2, 3 }, 
                              { 9, 5, 1, 2 } };//测试矩阵
            bool res= IsToplitz(matrix);
            Console.WriteLine($"{res}");
        }

        private static bool IsToplitz(int[,] matrix)
        {
            if (matrix == null) return false;
            //throw new NotImplementedException();
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            for(int i = 0; i < row; i++)//从第一行开始判断
            {
                int j = 0;//列号
                int k = i;//行号
                while (k<row&&j<col) //行列增加判断是否相同
                {
                    if (matrix[k, j] != matrix[i, 0]) { return false; }//不同直接返回false
                    k++;
                    j++;
                }
            }

            for (int i = 0; i < col; i++)//第一列开始判断
            {
                int j = 0;//行号
                int k = i;//列号
                while (j<row&&k<col)
                {
                    if (matrix[j, k] != matrix[0, i]) { return false; }
                    k++;
                    j++;
                }
            }

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo01;

namespace demo02
{
    enum ShapType {Triangle, Rectangle,Square};
    class ShapeFactory
    {
        public Shape GetShape(ShapType shapeType, params int[] arr) {
            switch(shapeType)
            {
                case ShapType.Triangle: if (arr.Length < 2) throw new ArgumentException("三角形需要两个参数");
                                         else return new Triangle(arr[0],arr[1]);
                case ShapType.Rectangle: if (arr.Length < 2) throw new ArgumentException("长方形需要两个参数");
                                          else return new Rectangle(arr[0],arr[1]);
                case ShapType.Square: if (arr.Length < 1) throw new ArgumentException("正方形需要两个参数");
                                        else  return new Square(arr[0]);
                default: throw new ArgumentException("参数错误");
            }

        }
        public Shape GetRandomShape()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            int shapeNum=random.Next(0,3);
            int paramNum1=random.Next(1,11);
            int paramNum2=random.Next(1,11);
            
            switch (shapeNum)
            {
                case 0: return GetShape(ShapType.Triangle, paramNum1, paramNum2);
                case 1: return GetShape(ShapType.Rectangle, paramNum1, paramNum2);
                case 2: return GetShape(ShapType.Square, paramNum1);
            }
            return null;
        }
    }
}

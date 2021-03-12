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
            Triangle triangle = new Triangle(3, 5);
            Rectangle rectangle = new Rectangle(3, 5);
            Shape square = new Square(4);
            Console.WriteLine(square.GetShapeType());
            Console.WriteLine($"三角形：合理？{triangle.IsRightShape()} 面积：{triangle.GetShapeArea()}");
            Console.WriteLine($"长方形：合理？{rectangle.IsRightShape()} 面积：{rectangle.GetShapeArea()}");
            Console.WriteLine($"正方形：合理？{square.IsRightShape()} 面积：{square.GetShapeArea()}");
            //Triangle wrongtriangle = new Triangle(-3, -5);
            // Console.WriteLine($"三角形：合理？{wrongtriangle.IsRightShape()} 面积：{wrongtriangle.GetShapeArea()}");
        }
    }
}

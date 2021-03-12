using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using demo01;
namespace demo02
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();
            Triangle triangle = (Triangle)factory.GetShape(ShapType.Triangle,3,5);//多态编译看左边，运行看右边
                                                                                  //访问不了参数，只有接口的方法可以调用
            factory.GetShape(ShapType.Triangle, 3, 5);
            Shape rectangle = factory.GetShape(ShapType.Rectangle,3,5);
            Shape square = factory.GetShape(ShapType.Square,4);

            //随机创建对象
            for(int i = 0; i < 10; i++)
            {
                Shape shape = factory.GetRandomShape();
                Console.WriteLine(shape.GetShapeType()) ;
                Console.WriteLine("面积："+shape.GetShapeArea());
                Console.WriteLine();
                Thread.Sleep(1);
            }

        }
    }
}

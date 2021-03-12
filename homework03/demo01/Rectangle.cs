using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
     public class Rectangle:Shape
    {
        private int length;
        private int width;

        public Rectangle() { }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int Length { get => length; set => length = value; }
        public int Width { get => width; set => width = value; }

        public double GetShapeArea()
        {
            if (this.IsRightShape()) return Length * Width;
            else return -1;
        }

        public bool IsRightShape()
        {
            if (length < 0 && width < 0) throw new ArgumentException("边长不可以小于0");
            return true;
        }

        public virtual string GetShapeType()
        {
           return $"长方形 长{this.length}  宽{this.width}";
        }
    }
}

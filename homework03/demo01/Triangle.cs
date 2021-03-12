using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
   public class Triangle : Shape
    {
        private int height;
        private int baseSide;

        public int BaseSide { get => baseSide; set => baseSide = value; }
        public int Height
        {
            get => height;
            set => height = value;
        }

        public Triangle(int height,int baseSide) { this.height = height;this.baseSide = baseSide; }//构造方法

        public Triangle(){}

        public double GetShapeArea()
        {
            if (this.IsRightShape())
                return 0.5 * (height * baseSide);
            else return -1;
        }

        public bool IsRightShape()
        {
            if (height < 0 && baseSide < 0) throw new ArgumentException("三角形边长、高不可以小于0");
            return true;
        }

        string Shape.GetShapeType()
        {
            return "三角形"+$" 底边{this.baseSide} 高{this.height}";
        }
    }
}

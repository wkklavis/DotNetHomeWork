using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
   public class Square : Rectangle
    {
        private int side;
        public Square(int side) : base(side, side) { }
        public Square() : base() { }

        public int Side { get => side; set => side = value; }

        public override string GetShapeType()
        {
            return $"正方形  边长{this.side}";
        }
    }
}

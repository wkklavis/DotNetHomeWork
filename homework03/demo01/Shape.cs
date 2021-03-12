using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
    public interface Shape
    {
        double GetShapeArea();
        bool IsRightShape();

        string GetShapeType();
    }
}

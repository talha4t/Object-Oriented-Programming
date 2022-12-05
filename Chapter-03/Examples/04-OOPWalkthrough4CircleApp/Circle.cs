using System;
using System.Collections.Generic;
using System.Text;

namespace _04_OOPWalkthrough4CircleApp
{
    public class Circle
    {
        public double radius;
        public double GetDiameter()
        {
            return 2 * radius;
        }
        public double GetPerimeter()
        {
            return Math.PI * GetDiameter();
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOPWalkthrough4CircleApp
{
    internal class Circle
    {
        public double radius;
        public double GetDiameter()
        {
            return 2 * radius;
        }
        public double GetPerimeter()
        {
            return Math.PI * GetPerimeter();
        }
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}

using _04_OOPWalkthrough4CircleApp;
using System;

namespace OOPWalkthrough4CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter the radius of a circle: ");
                string radiusInString = Console.ReadLine();
                double radius = Convert.ToDouble(radiusInString);
                Circle aCircle = new Circle();
                aCircle.radius = radius;
                Console.WriteLine("Diameter: " + aCircle.GetDiameter());
                Console.WriteLine("Perimeter: " + aCircle.GetPerimeter());
                Console.WriteLine("Area: " + aCircle.GetArea());
                Console.WriteLine();
                Console.WriteLine("Want to do it again? press Y");
                string key = Console.ReadLine();

                if (key.ToUpper() != "Y")
                {
                    break;
                }
            }
        }
    }
}

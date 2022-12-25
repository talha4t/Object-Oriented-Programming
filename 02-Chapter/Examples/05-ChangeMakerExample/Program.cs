using System;
using System.Xml.Serialization;

namespace _05_ChangeMakerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            Console.WriteLine("Before: " + a);

            ChangeTheNumber(a);

            Console.WriteLine("After: " + a);
        }

        private static void ChangeTheNumber(int aNumber)
        {
            aNumber = 200;
        }
    }
}

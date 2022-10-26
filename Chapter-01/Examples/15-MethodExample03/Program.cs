using System;

namespace _15_MethodExample03
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = 300;
            double number2 = 450.5;
            double addResult = Add(number1, number2);

            Console.WriteLine(addResult);
        }

        static double Add(double num1, double num2)
        {
            double result = num1 + num2;

            return result;
        }
    }
}
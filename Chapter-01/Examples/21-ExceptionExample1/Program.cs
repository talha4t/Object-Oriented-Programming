using System;

namespace _21_ExceptionExample1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();

            try
            {
                double aNumber = Convert.ToDouble(input);
                Console.WriteLine("You have entered: " + aNumber);

            }

            catch (Exception exObj)
            {
                Console.WriteLine("You have entered text. " + "Please enter number only");
            }

            finally
            {
                Console.WriteLine("Finally code here...");
            }

            Console.ReadKey();
        }
    }
}
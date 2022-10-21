using System;

namespace ConditionalStatementExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string userInput = Console.ReadLine();

            int aNumber = Convert.ToInt16(userInput);

            if (aNumber >= 0)
            {
                Console.WriteLine("You have entered a positive number");
            }
            else
            {
                Console.WriteLine("You have entered a negative number");
            }
        }
    }
}
using System;

namespace VariableExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Talha";
            string lastName = "Mahmud";
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName);
        }
    }
}
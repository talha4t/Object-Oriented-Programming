using System;
namespace _19_ArrayExample2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("**This program shows only even numbers " +
                "of your number list**");
            Console.WriteLine("How many number will you enter: ");
            int arraysize = Convert.ToInt32(Console.ReadLine());

            int[] allNumber = new int[arraysize];
            for (int index = 0; index < arraysize; index++)
            {
                Console.WriteLine("Enter number " + (index + 1));
                int aNumber = Convert.ToInt32(Console.ReadLine());

                allNumber[index] = aNumber;
            }

            Console.WriteLine("Here even numbers are:");
            for (int index = 0; index < arraysize; index++)
            {
                int aNumber = allNumber[index];
                if (aNumber % 2 == 0)
                {
                    Console.Write(aNumber + " ");
                }
            }

        }
    }
}
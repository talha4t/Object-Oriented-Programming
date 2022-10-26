using System;

namespace _14_MethodExample02
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowName("Talha");
            string name = "Mahmud";
            ShowName(name);
            Console.ReadKey();
        }

        static void ShowName(string aName)
        {
            Console.WriteLine(aName);
        }
    }
}
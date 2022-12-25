using System; 

namespace _06_RefOfPrimitveType
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 100;
            int b = 200;

            Console.WriteLine("a = " + a + ", b = " + b);

            Swap(ref a, ref b);

            Console.WriteLine("a = " + a + ", b = " + b);
            
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}

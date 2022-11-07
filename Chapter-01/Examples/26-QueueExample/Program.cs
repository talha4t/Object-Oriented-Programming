using System;

namespace _26_QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> someValues = new Queue<int>();
            someValues.Enqueue(100);
            someValues.Enqueue(200);
            someValues.Enqueue(300);

            Console.WriteLine(someValues.Dequeue());
            Console.WriteLine(someValues.Dequeue());
            Console.WriteLine(someValues.Dequeue());
        }
    }
}
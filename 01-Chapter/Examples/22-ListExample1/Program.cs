using System;

namespace _22_ListExample1
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> nameList = new List<string>();

            nameList.Add("Talha");
            nameList.Add("Pavel");
            nameList.Add("Hemayet");
            nameList.Add("Shaptak");
            nameList.Add("Shihab");

            foreach (string aName in nameList)
            {
                Console.WriteLine(aName);
            }

            //string name = nameList[2];
            //nameList.Remove("Pavel");
            //nameList[0] = "Nayon";


            //Console.WriteLine(nameList[0], name);
        }
    }
}
using System;

namespace _23_hashSetExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            HashSet<string> allRegistrationNo = new HashSet<string>();


            allRegistrationNo.Add("11-00-001");
            allRegistrationNo.Add("11-00-005");
            allRegistrationNo.Add("22-00-001");
            allRegistrationNo.Add("11-11-001");
            allRegistrationNo.Add("11-00-001"); // duplicate data

            foreach (string aRegiNo in allRegistrationNo)
            {
                Console.WriteLine(aRegiNo);
            }
        }
    }
}
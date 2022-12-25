using System;

namespace _24_dictonaryExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, double> salary = new Dictionary<string, double>();

            salary.Add("emp-098", 25000);
            salary.Add("emp-012", 34000);
            salary.Add("emp-342", 11000);
            salary.Add("emp-111", 25000);

            Console.WriteLine("Emplyee Code || Salary Amount");

            foreach (KeyValuePair<string, double> codeSalary in salary)
            {
                Console.WriteLine(codeSalary.Key + " || " + codeSalary.Value);
            }
        }
    }
}
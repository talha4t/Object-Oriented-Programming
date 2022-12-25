using System;

namespace _04_ObjectInMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();

            employee1.id = "emp-212";
            employee1.name = "Talha";
            employee1.salaryAmount = 50000;

            Employee employee2 = new Employee();

            employee2.id = "emp-100";
            employee2.name = "Mahmud";
            employee2.salaryAmount = 500000;
        }
    }
}
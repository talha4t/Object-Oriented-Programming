using _06_ChangeMakerExample2;
using System;

namespace _06_StudentExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.name = "Talha";
            st1.cGPA = 4.00;

            Console.WriteLine("Before: " + st1.name + " " + st1.cGPA +
                                " " + st1.ageInYear);

            ChangeTheStudent(st1);

            Console.WriteLine("After: " + st1.name + " " + st1.cGPA +
                                " " + st1.ageInYear);

        }

        public static void ChangeTheStudent(Student aStudent)
        {
            aStudent.name = "Mahmud";
            aStudent.cGPA = 4.00;
            aStudent.ageInYear = 20;
        }
    }
}

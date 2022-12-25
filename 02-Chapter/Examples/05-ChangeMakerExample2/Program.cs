using System;

namespace _05_ChangeMakerExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.name = "Talha";
            st1.cGPA = 4.00;
            Console.WriteLine("Before: " + st1.name + " " + st1.cGPA + " " + st1.ageInYear);

            ChangeTheStudent(st1);

            Console.WriteLine("After: " + st1.name + " " + st1.cGPA + " " + st1.ageInYear);
        }
        public static void ChangeTheStudent(Student aStudent)
        {
            aStudent.name = "Pavel";
            aStudent.cGPA = 3.89;
            aStudent.ageInYear = 19;
        }
    }
}
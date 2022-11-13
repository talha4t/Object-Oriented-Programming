﻿using System;

namespace _3_objectClass
{
    class Program
    {
        public class Student
        {
            public string name;
            public double cGPA;
            public int ageInYear;
        }
        public static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.name = "Talha";
            st1.cGPA = 4.00;
            st1.ageInYear = 19;

            Student st2 = st1;

            st2.name = "Pavel";
            st2.cGPA = 3.89;
            st2.ageInYear = 20;

            Console.WriteLine(st1.name);
            Console.WriteLine(st1.cGPA);
            Console.WriteLine(st1.ageInYear);
            Console.WriteLine("----");
            Console.WriteLine(st2.name);
            Console.WriteLine(st2.cGPA);
            Console.WriteLine(st2.ageInYear);
        }
    }
}
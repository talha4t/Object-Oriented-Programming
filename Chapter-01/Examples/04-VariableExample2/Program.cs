using System;

namespace VarbiableExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte aByte = 12;
            short aSmallValue = 45;
            int noOfStudents = 100;
            int noOfReaminingOver = 23;
            long population = 340000000;

            double salaryAmount = 45000.50;
            float valueOfSomething = 78.98f;
            decimal divisionResult = 34.43m;

            double mathObtainedScore = 98.5;
            double physicsObtainedScore = 86;
            double chemistryObtainedScore = 88;

            int noOfSubjects = 3;
            double totalObtainedScore = mathObtainedScore + physicsObtainedScore + chemistryObtainedScore;

            double avgObtainedScore = totalObtainedScore / noOfSubjects;

            Console.WriteLine(avgObtainedScore);
        }

    }
}
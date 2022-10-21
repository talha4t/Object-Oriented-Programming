using System;

namespace VariableExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Math Score: ");
            string mathScoreInString = Console.ReadLine();
            Console.Write("Enter Physics Score: ");
            string physicsScoreInString = Console.ReadLine();
            Console.Write("Etner Chemistry Score: ");
            string chemistryScoreInString = Console.ReadLine();

            double mathObtainedScore = Convert.ToDouble(mathScoreInString);
            double physicsObtainedScore = Convert.ToDouble(physicsScoreInString);
            double chemistryObtainedScore = Convert.ToDouble(chemistryScoreInString);

            double noOfSubjects = 3;

            double totalObtainedScore = mathObtainedScore + physicsObtainedScore + chemistryObtainedScore;

            double avgObtainedScore = totalObtainedScore / noOfSubjects;

            Console.WriteLine("Avg Score: " + avgObtainedScore);

        }
    }
}
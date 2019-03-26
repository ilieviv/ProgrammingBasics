using System;

namespace _07._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();

            double sumGrades = 0;
            double averageGrade = 0;
            double finalAssessment = 0;
            int tasksCounter = 0;

            while (presentationName != "Finish")
            {
                for (int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumGrades += grade;
                }

                averageGrade = sumGrades / n;
                Console.WriteLine(presentationName + " - {0:f2}.", averageGrade);

                finalAssessment += averageGrade;
                sumGrades = 0;
                averageGrade = 0;
                tasksCounter++;

                presentationName = Console.ReadLine();
            }
            finalAssessment /= tasksCounter;
            Console.WriteLine("Student's final assessment is {0:f2}.", finalAssessment);
        }
    }
}

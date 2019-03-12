using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int negativeGrade = int.Parse(Console.ReadLine());

            int negativeCounter = 0;
            int positiveGrade = 0;
            double averageScore = 0;
            int counter = 0;
            string successExam = string.Empty;
            bool fail = false;
            string exam = string.Empty;

            while (negativeCounter < negativeGrade)
            {
                exam = Console.ReadLine();

                if (exam == "Enough")
                {
                    break;
                }
                else
                {
                    successExam = exam;
                    double grade = double.Parse(Console.ReadLine());
                    if (grade <= 4)
                    {
                        negativeCounter++;
                    }
                    averageScore += grade;
                    positiveGrade++;
                }

                if (negativeCounter == negativeGrade)
                {
                    fail = true;
                    break;
                }

                counter++;
            }

            averageScore /= positiveGrade;
            if (fail)
            {
                Console.WriteLine("You need a break, {0} poor grades.", negativeCounter);
            }
            else
            {
                Console.WriteLine($"Average score: {averageScore:f2} \nNumber of problems: {counter}\nLast problem: {successExam}");
            }
        }
    }
}

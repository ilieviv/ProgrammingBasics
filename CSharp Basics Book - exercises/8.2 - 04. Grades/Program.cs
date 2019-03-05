using System;

namespace _8._2___04._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double grade = 0;
            double sumGrade = 0;
            double average = 0;
            double g1 = 0;
            double g2 = 0;
            double g3 = 0;
            double g4 = 0;

            for (int i = 0; i < students; i++)
            {
                grade = double.Parse(Console.ReadLine());
                sumGrade += grade;
                if (grade >= 5)
                {
                    g1++;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    g2++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    g3++;
                }
                else if (grade >= 2 && grade <= 2.99)
                {
                    g4++;
                }
            }
            average = sumGrade / students;

            Console.WriteLine("Top students: {0:f2}%", (g1 / students) * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", (g2 / students) * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", (g3 / students) * 100);
            Console.WriteLine("Fail: {0:f2}%", (g4 / students) * 100);
            Console.WriteLine("Average: {0:f2}", average);
        }
    }
}

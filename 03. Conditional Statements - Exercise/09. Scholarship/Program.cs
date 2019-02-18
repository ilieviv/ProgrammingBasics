using System;

namespace _09._Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialScolarship = 0;
            double gradeScolarship = 0;

            if (income < minSalary && grade > 4.50)
            {
                socialScolarship = Math.Floor(0.35 * minSalary);
            }

            if (grade >= 5.50)
            {
                gradeScolarship = Math.Floor(25 * grade);
            }

            if (socialScolarship == 0 && gradeScolarship == 0)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (socialScolarship != 0 && gradeScolarship == 0)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", socialScolarship);
            }
            else if (socialScolarship == 0 && gradeScolarship != 0)
            {
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", gradeScolarship);
            }
            else
            {
                if (socialScolarship>gradeScolarship)
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", socialScolarship);
                }
                else if (socialScolarship<=gradeScolarship)
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", gradeScolarship);
                }
            }

        }
    }
}

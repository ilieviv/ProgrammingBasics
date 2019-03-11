using System;

namespace _07._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double sum = 0.0;
            int counter = 0;
            int fail = 0;
            bool outSchool = false;

            while (counter < 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >=4)
                {
                    sum += grade;
                    counter++;
                    fail = 0;
                }
                else
                {
                    fail++;
                }

                if (fail ==2)
                {
                    Console.WriteLine("{0} has been excluded at {1} grade", name, counter+1);
                    outSchool = true;
                    break;
                }

            }

            if (!outSchool)
            {
                Console.WriteLine($"{name} graduated. Average grade: {(sum/12.0):f2}");
            }
         
        }
    }
}

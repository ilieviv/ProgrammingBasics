using System;

namespace _06._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumFirst = 0;
            int sumSecond = 0;

            for (int i = 0; i < n * 2; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    sumFirst += num;
                }
                else
                {
                    sumSecond += num;
                }

            }
            if (sumFirst == sumSecond)
            {
                Console.WriteLine("Yes, sum = {0}", sumFirst);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(sumFirst - sumSecond));
            }

        }
    }
}

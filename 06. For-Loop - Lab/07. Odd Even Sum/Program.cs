using System;

namespace _07._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i%2==1)
                {
                    oddSum += num;
                }
                else
                {
                    evenSum += num;
                }
            }

            if (oddSum==evenSum)
            {
                Console.WriteLine("Yes\nSum = {0}", evenSum);
            }
            else
            {
                Console.WriteLine("No\nDiff = {0}", Math.Abs(oddSum-evenSum));
            }
        }
    }
}

using System;

namespace _04._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int d1 = 0;
            int d2 = 0;
            int d3 = 0;
            int d4 = 0;
            int d5 = 0;
            int d6 = 0;

            for (int i = n1; i <= n2; i++)
            {
                int num = i;

                d1 = num % 10;
                num /= 10;
                d2 = num % 10;
                num /= 10;
                d3 = num % 10;
                num /= 10;
                d4 = num % 10;
                num /= 10;
                d5 = num % 10;
                num /= 10;
                d6 = num % 10;

                if (d1 + d3 + d5 == d2 + d4 + d6)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

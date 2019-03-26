using System;

namespace _05._Equal_Sums_Left_Right_Position
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

                if ((d1 + d2) == (d4 + d5))
                {
                    Console.Write(i + " ");
                }
                else if ((d1 + d2) > (d4 + d5))
                {
                    if ((d4 + d5 + d3) == (d1 + d2))
                    {
                        Console.Write(i + " ");
                    }
                }
                else if ((d1 + d2) < (d4 + d5))
                {
                    if ((d1 + d2 + d3) == (d4 + d5))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}

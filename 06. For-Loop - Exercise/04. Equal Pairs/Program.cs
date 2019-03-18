using System;

namespace _04._Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumFirst = 0;
            int sumSecond = 0;
            int diff = 0;
            bool equal = true;

            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    sumFirst = num1 + num2;
                    equal = true;
                }

                if (n == 1)
                {
                    break;
                }
                else
                {
                    sumSecond = num1 + num2;
                }

                if (sumFirst != sumSecond)
                {
                    equal = false;
                    if (Math.Abs((sumFirst - sumSecond)) > diff)
                    {
                        diff = Math.Abs(sumSecond - sumFirst);
                    }
                }
                else
                {
                    equal = true;
                }

                sumFirst = sumSecond;
            }

            if (equal)
            {
                Console.WriteLine("Yes, value={0}", sumFirst);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", diff);
            }
        }
    }
}

using System;

namespace _5._1___10._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxN = 0;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                sum += number;

                if (maxN<number)
                {
                    maxN = number;
                }
            }

            if (maxN == (sum-maxN))
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + (sum/2));
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(maxN-(sum-maxN)));
            }





        }
    }
}

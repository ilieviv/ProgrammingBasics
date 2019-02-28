using System;

namespace _8._1___08._Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var previous = int.MinValue;

            int count = 0;
            int maxCount = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > previous)
                {
                    count += 1;
                }
                else
                {
                    count = 1;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                }
                previous = num;
            }

            Console.WriteLine(maxCount);
        }
    }
}

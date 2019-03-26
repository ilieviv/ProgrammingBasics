using System;

namespace _10._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int num = i;
                int d1 = num % 10;
                num /= 10;
                int d2 = num % 10;
                num /= 10;
                int d3 = num % 10;
                num /= 10;
                int d4 = num % 10;

                if (d1 == 0 || d2 == 0 | d3 == 0 | d4 == 0)
                {
                    continue;
                }

                bool magic = n % d1 == 0 && n % d2 == 0 && n % d3 == 0 && n % d4 == 0;

                if (magic)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

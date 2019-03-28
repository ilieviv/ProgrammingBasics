using System;

namespace _04._Car_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int d1 = n1 + 1; d1 <= n2; d1++)
            {
                for (int d2 = n1; d2 <= n2; d2++)
                {
                    for (int d3 = n1; d3 <= n2; d3++)
                    {
                        for (int d4 = n1; d4 <= n2; d4++)
                        {
                            if (d1 > d4 && (d2 + d3) % 2 == 0)
                            {
                                if ((d1 % 2 == 0 && d4 % 2 == 1) || (d1 % 2 == 1 && d4 % 2 == 0))
                                {
                                    Console.Write($"{d1}{d2}{d3}{d4} ");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

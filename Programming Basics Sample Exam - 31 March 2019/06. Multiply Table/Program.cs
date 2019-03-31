using System;

namespace _06._Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int d1 = n % 10;
            n /= 10;
            int d2 = n % 10;
            n /= 10;
            int d3 = n % 10;

            int total = 0;

            for (int i = 1; i <= d1; i++)
            {
                for (int j = 1; j <= d2; j++)
                {
                    for (int k = 1; k <= d3; k++)
                    {
                        if (i != 0 && j != 0 && k != 0)
                        {
                            total = i * j * k;
                            Console.WriteLine($"{i} * {j} * {k} = {total};");
                        }
                    }
                }
            }
        }
    }
}

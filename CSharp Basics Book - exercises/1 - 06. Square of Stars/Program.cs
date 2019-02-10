using System;

namespace _1___06._Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    for (int l = 1; l <= n; l++)
                    {
                        Console.Write("*");
                    }
                }
                else if (1<i & i<n)
                {
                    Console.Write("*");
                    for (int l = 1; l <= n-2; l++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");

                }
                else
                {
                    if (i == n)
                    {
                        for (int s = 1; s <= n; s++)
                        {
                            Console.Write("*");
                        }
                    }
                }
                Console.WriteLine();

            }
            Console.WriteLine();
        }
    }
}

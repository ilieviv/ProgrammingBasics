﻿using System;

namespace _8._1___10._Rectangle_with_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('%', 2 * n));

            if (n % 2 == 0)
            {
                for (int i = 1; i < n; i++)
                {
                    if (i == n / 2)
                    {
                        Console.WriteLine("%{0}**{0}%", new string(' ', n - 2));
                    }
                    else
                    {
                        Console.WriteLine("%{0}%", new string(' ', 2 * n - 2));

                    }
                }
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i == n / 2 + 1)
                    {
                        Console.WriteLine("%{0}**{0}%", new string(' ', n - 2));
                    }
                    else
                    {
                        Console.WriteLine("%{0}%", new string(' ', 2 * n - 2));

                    }
                }
            }

            Console.WriteLine(new string('%', 2 * n));
        }
    }
}

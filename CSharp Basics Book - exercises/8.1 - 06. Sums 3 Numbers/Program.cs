﻿using System;

namespace _8._1___06._Sums_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n1 + n2 == n3)
            {
                Console.WriteLine($"{Math.Min(n1, n2)} + {Math.Max(n1, n2)} = {n3}");
            }
            else if (n1 + n3 == n2)
            {
                Console.WriteLine($"{Math.Min(n1, n3)} + {Math.Max(n1, n3)} = {n2}");
            }
            else if (n2 + n3 == n1)
            {
                Console.WriteLine($"{Math.Min(n2, n3)} + {Math.Max(n2, n3)} = {n1}");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
﻿using System;

namespace _03___binary_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int i = 1;
            int mask = i << p;

            Console.WriteLine((n & mask) != 0 ? 1 : 0);
        }
    }
}

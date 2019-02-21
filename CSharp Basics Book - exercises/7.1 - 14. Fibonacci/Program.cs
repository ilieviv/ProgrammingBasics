﻿using System;

namespace _7._1___14._Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var f0 = 1;
            var f1 = 1;

            for (int i = 0; i < n - 1; i++)
            {
                var fNext = f0 + f1;
                f0 = f1;
                f1 = fNext;
            }
            Console.WriteLine(f1);
        }
    }
}

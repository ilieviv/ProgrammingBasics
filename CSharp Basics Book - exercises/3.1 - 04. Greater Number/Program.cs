﻿using System;

namespace _3._1___04._Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a);
            }

        }
    }
}

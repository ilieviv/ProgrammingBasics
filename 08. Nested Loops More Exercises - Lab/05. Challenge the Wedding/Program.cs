﻿using System;

namespace _05._Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int woman = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 1; i <= men; i++)
            {
                for (int j = 1; j <= woman; j++)
                {
                    Console.Write($"({i} <-> {j}) ");
                    counter++;
                    if (counter == tables)
                    {
                        return;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

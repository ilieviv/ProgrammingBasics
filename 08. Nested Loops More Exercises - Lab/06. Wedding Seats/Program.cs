﻿using System;

namespace _06._Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char sector = char.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int seats = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 'A'; i <= sector; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    if (j % 2 == 1)
                    {
                        for (int k = 1; k <= seats; k++)
                        {
                            Console.WriteLine($"{(char)i}{j}{(char)(k + 96)}");
                            total++;
                        }
                    }
                    else if (j % 2 == 0)
                    {
                        for (int k = 1; k <= seats + 2; k++)
                        {
                            Console.WriteLine($"{(char)i}{j}{(char)(k + 96)}");
                            total++;
                        }
                    }
                }
                rows++;
            }
            Console.WriteLine(total);
        }
    }
}

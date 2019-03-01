﻿using System;

namespace _8._1___12._Generate_Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int count = 0;
            int area = 0;

            for (int left = -n; left < n; left++)
            {
                for (int top = -n; top < n; top++)
                {
                    for (int right = left + 1; right <= n; right++)
                    {
                        for (int bottom = top + 1; bottom <= n; bottom++)
                        {
                            area = Math.Abs(right - left) * Math.Abs(bottom - top);

                            if (area >= m)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom, area);
                                count++;
                            }
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}

﻿using System;

namespace _3._1___06._Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            double points = int.Parse(Console.ReadLine());
            double bonus = 0;

            if (points<=100)
            {
                bonus = 5;
            }else if (points <= 1000)
            {
                bonus = 0.2 * points;
            }else
            {
                bonus = 0.1 * points;
            }

           if (points%2==0)
            {
                bonus += 1;
            }
           else if (points%5==0)
            {
                bonus += 2;
            }

            points = points + bonus;

            Console.WriteLine(bonus);
            Console.WriteLine(points);
        }
    }
}

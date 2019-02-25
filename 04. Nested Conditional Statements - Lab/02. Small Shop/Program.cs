﻿using System;

namespace _02._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string city = Console.ReadLine().ToLower();
            float quantity = float.Parse(Console.ReadLine());
            double price = 0;
            double sum = 0;

            if (city == "sofia")
            {
                switch (product)
                {
                    case "coffee": price = 0.50; break;
                    case "water": price = 0.80; break;
                    case "beer": price = 1.20; break;
                    case "sweets": price = 1.45; break;
                    case "peanuts": price = 1.60; break;
                    default:
                        break;
                }
            }
            else if (city == "plovdiv")
            {
                switch (product)
                {
                    case "coffee": price = 0.40; break;
                    case "water": price = 0.70; break;
                    case "beer": price = 1.15; break;
                    case "sweets": price = 1.30; break;
                    case "peanuts": price = 1.50; break;
                    default:
                        break;
                }
            }
            else if (city == "varna")
            {
                switch (product)
                {
                    case "coffee": price = 0.45; break;
                    case "water": price = 0.70; break;
                    case "beer": price = 1.10; break;
                    case "sweets": price = 1.35; break;
                    case "peanuts": price = 1.55; break;
                    default:
                        break;
                }
            }

            sum = quantity * price;
            Console.WriteLine(sum);
        }
    }
}

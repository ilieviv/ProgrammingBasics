using System;

namespace _06._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;
            double sum = 0;

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                switch (fruit)
                {
                    case "banana": price = 2.50; break;
                    case "apple": price = 1.20; break;
                    case "orange": price = 0.85; break;
                    case "grapefruit": price = 1.45; break;
                    case "kiwi": price = 2.70; break;
                    case "pineapple": price = 5.50; break;
                    case "grapes": price = 3.85; break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (day == "saturday" || day == "sunday")
            {
                switch (fruit)
                {
                    case "banana": price = 2.70; break;
                    case "apple": price = 1.25; break;
                    case "orange": price = 0.9; break;
                    case "grapefruit": price = 1.6; break;
                    case "kiwi": price = 3; break;
                    case "pineapple": price = 5.60; break;
                    case "grapes": price = 4.2; break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            sum = price * quantity;
            if (price > 0)
            {
                Console.WriteLine("{0:f2}", sum);
            }
        }
    }
}

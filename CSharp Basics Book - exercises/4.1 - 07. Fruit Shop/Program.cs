using System;

namespace _4._1___07._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            var week = day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday";
            var weekEnd = day == "Saturday" || day == "Sunday";
            double price = 0;

            if (week)
            {
                if (fruit == "banana")
                {
                     price = 2.5 * quantity;
                }
                else if (fruit == "apple")
                {
                     price = 1.2 * quantity;
                }
                else if (fruit == "orange")
                {
                     price = 0.85 * quantity;
                }
                else if (fruit == "grapefruit")
                {
                     price = 1.45 * quantity;
                }
                else if (fruit == "kiwi")
                {
                     price = 2.7 * quantity;
                }
                else if (fruit == "pineapple")
                {
                     price = 5.5* quantity;
                }
                else if (fruit == "grapes")
                {
                     price = 3.85 * quantity;
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine("{0:f2}", price);
            }
            else if (weekEnd)
            {
                if (fruit == "banana")
                {
                    price = 2.7 * quantity;
                }
                else if (fruit == "apple")
                {
                    price = 1.25 * quantity;
                }
                else if (fruit == "orange")
                {
                    price = 0.90 * quantity;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.60 * quantity;
                }
                else if (fruit == "kiwi")
                {
                    price = 3 * quantity;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.6 * quantity;
                }
                else if (fruit == "grapes")
                {
                    price = 4.2 * quantity;
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine("{0:f2}", price);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}

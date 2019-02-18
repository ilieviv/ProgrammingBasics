using System;

namespace _12._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursion = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int dools = int.Parse(Console.ReadLine());
            int beers = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double profit = 0;
            double moneyLeft = 0;

            int orderQuantity = puzzle + dools + beers + minions + trucks;
            double order = (puzzle*2.60) + (dools * 3) + (beers * 4.1) + (minions * 8.2) + (trucks * 2);

            if (orderQuantity >= 50)
            {
                order = order - (order * 0.25);
            }

            profit = order - (order * 0.1);
            moneyLeft = Math.Abs(profit - excursion);


            if (profit >= excursion)
            {
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {moneyLeft:f2} lv needed.");
            }
           
        }
    }
}

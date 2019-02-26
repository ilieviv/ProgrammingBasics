using System;

namespace _05._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishMans = int.Parse(Console.ReadLine());
            int price = 0;
            double discount = 0;
            double sum = 0;

            if (season == "Spring")
            {
                price = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                price = 4200;
            }
            else if (season == "Winter")
            {
                price = 2600;
            }

            if (fishMans <= 6)
            {
                discount = 0.1;
            }
            else if (fishMans >= 7 && fishMans <= 11)
            {
                discount = 0.15;
            }
            else
            {
                discount = 0.25;
            }

            sum = price - (price * discount);

            if (fishMans % 2 == 0 && season != "Autumn")
            {
                sum -= sum * 0.05;
            }

            double difference = Math.Abs(budget - sum);

            if (budget >= sum)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", difference);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", difference);
            }

        }
    }
}

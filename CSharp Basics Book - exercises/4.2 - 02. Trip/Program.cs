using System;

namespace _4._2___02._Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string city = "";
            string accomodation = "";
            double spentBudget = 0;

            if (budget <=100)
            {
                city = "Bulgaria";

                if (season == "summer")
                {
                    spentBudget = 0.30 * budget;
                    accomodation = "Camp";
                }
                else
                {
                    spentBudget = 0.70 * budget;
                    accomodation = "Hotel";
                }
            }
            else if (budget >100 && budget <=1000)
            {
                city = "Balkans";
                if (season == "summer")
                {
                    spentBudget = 0.40 * budget;
                    accomodation = "Camp";
                }
                else
                {
                    spentBudget = 0.80 * budget;
                    accomodation = "Hotel";
                }
            }
            else
            {
                city = "Europe";
                spentBudget = 0.90 * budget;
                accomodation = "Hotel";
            }



            Console.WriteLine($"Somewhere in {city}");
            Console.WriteLine($"{accomodation} - {spentBudget:f2}");


        }
    }
}

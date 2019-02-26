using System;

namespace _06._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string venue = string.Empty;
            string destination = string.Empty;

            if (season == "summer")
            {
                venue = "Camp";
            }
            if (season == "winter")
            {
                venue = "Hotel";
            }

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    budget = 0.30 * budget;
                }
                else
                {
                    budget = 0.70 * budget;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    budget = 0.40 * budget;
                }
                else
                {
                    budget = 0.80 * budget;
                }
            }
            else
            {
                destination = "Europe";
                budget = budget * 0.90;
                venue = "Hotel";
            }

            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1:f2}", venue, budget);

        }
    }
}

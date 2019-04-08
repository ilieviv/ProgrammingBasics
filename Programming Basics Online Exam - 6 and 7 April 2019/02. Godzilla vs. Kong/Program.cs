using System;

namespace _02._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double priceCloth = double.Parse(Console.ReadLine());

            double decor = budget * 0.1d;

            double statistsTotal = statists * priceCloth;

            if (statists > 150)
            {
                statistsTotal = statistsTotal - (statistsTotal * 0.1d);
            }

            double total = statistsTotal + decor;

            double difference = Math.Abs(total - budget);

            if (total <= budget)
            {
                Console.WriteLine($"Action!" + Environment.NewLine + $"Wingard starts filming with {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money!" + Environment.NewLine + $"Wingard needs {difference:f2} leva more.");
            }
        }
    }
}

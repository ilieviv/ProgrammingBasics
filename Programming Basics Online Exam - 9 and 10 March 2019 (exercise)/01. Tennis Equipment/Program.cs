using System;

namespace _01._Tennis_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceRocket = double.Parse(Console.ReadLine());
            int rockets = int.Parse(Console.ReadLine());
            int shoes = int.Parse(Console.ReadLine());

            double sumRockets = priceRocket * rockets;
            double sumShoes = (priceRocket / 6d) * shoes;
            double otherStuff = 0.2 * (sumRockets + sumShoes);

            double totalDjokovic = (sumRockets + sumShoes + otherStuff) / 8;
            double sponsors = (sumRockets + sumShoes + otherStuff) - totalDjokovic;
            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(totalDjokovic)}" + Environment.NewLine + $"Price to be paid by sponsors {Math.Ceiling(sponsors)}");
        }
    }
}

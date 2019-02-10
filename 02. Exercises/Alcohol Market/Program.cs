using System;

namespace Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWhiskey = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());

            double priceRakia = priceWhiskey * 0.5;
            double priceWine = priceRakia - (priceRakia * 0.4);
            double priceBeer = priceRakia - (priceRakia * 0.8);

            double totalWhiskey = priceWhiskey * whiskey;
            double totalBeer = priceBeer * beer;
            double totalWine = priceWine * wine;
            double totalRakia = priceRakia * rakia;

            double totalSum = totalWhiskey + totalBeer + totalWine + totalRakia;

            Console.WriteLine($"{totalSum:f2}");

        }
    }
}

using System;

namespace _8._2___03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrizantems = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            decimal priceHrizantems = 0;
            decimal priceRoses = 0;
            decimal priceTulips = 0;

            decimal sum = 0;

            if (season.Equals("Summer") || season.Equals("Spring"))
            {
                priceHrizantems = 2;
                priceRoses = 4.1m;
                priceTulips = 2.5m;
            }
            else if (season.Equals("Winter") || season.Equals("Autumn"))
            {
                priceHrizantems = 3.75m;
                priceRoses = 4.5m;
                priceTulips = 4.15m;
            }

            if (holiday.Equals("Y"))
            {
                priceHrizantems *= 1.15m;
                priceRoses *= 1.15m;
                priceTulips *= 1.15m;
            }

            sum = hrizantems * priceHrizantems + roses * priceRoses + tulips * priceTulips;

            if (tulips > 7 && season.Equals("Spring"))
            {
                sum -= sum * 0.05m;
            }
            if (roses >= 10 && season.Equals("Winter"))
            {
                sum -= sum * 0.10m;
            }

            if (tulips + roses + hrizantems > 20)
            {
                sum -= sum * 0.20m;
            }

            Console.WriteLine("{0:f2}", sum + 2);
        }
    }
}

using System;

namespace _2._2___04._Money
{
    class Program
    {
        static void Main(string[] args)
        {
            double btc = double.Parse(Console.ReadLine());
            double cny = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double eur = 1.95;
            double usd = 1.76;
            double commisionPercent = commision / 100;

            double btcBGN = btc * 1168;
            double cnyBGN = cny * 0.15 * usd;

            double bgnEUR = (btcBGN + cnyBGN) / eur;
            double bgnEURcommision = bgnEUR -=bgnEUR * commisionPercent;

            Console.WriteLine(bgnEURcommision);

        }
    }
}

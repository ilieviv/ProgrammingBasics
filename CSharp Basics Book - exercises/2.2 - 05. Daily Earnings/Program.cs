using System;

namespace _2._2___05._Daily_Earnings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double usd = double.Parse(Console.ReadLine());

            double monthWage = n * m;
            double bonus = monthWage * 2.5;

            double yearWage = monthWage * 12 + bonus;
            double yearWageNet = yearWage -= yearWage * 0.25;

            double dayProfitUSD = yearWageNet/365;
            double dayProfitBGN = dayProfitUSD * usd;

            Console.WriteLine(Math.Round(dayProfitBGN, 2));

        }
    }
}

using System;

namespace _3._2___01._Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double taxiPrice;
            double busPrice = 0.09;
            double trainPrice = 0.06;

            double tripPrice = 0;
            double tripPriceTaxi = 0;
            double tripPriceBus = 0;
            double tripPriceTrain = 0;

            if (day=="day")
            {
                taxiPrice = 0.79;
            }
            else
            {
                taxiPrice = 0.90;
            }

            if (n<20)
            {
                tripPrice = 0.70 + taxiPrice * n;
            }
            else if (n>=20 && n<100)
            {
                tripPriceTaxi = 0.70 + taxiPrice * n;
                tripPriceBus = busPrice * n;
                tripPrice = Math.Min(tripPriceTaxi, tripPriceBus);
            }
            else if (n>=100)
            {
                tripPriceTaxi = 0.70 + taxiPrice * n;
                tripPriceBus = busPrice * n;
                tripPriceTrain = trainPrice * n;
                tripPrice = Math.Min(tripPriceTaxi, tripPriceBus);
                tripPrice = Math.Min(tripPrice, tripPriceTrain);
            }
            Console.WriteLine(tripPrice);
            
        }
    }
}

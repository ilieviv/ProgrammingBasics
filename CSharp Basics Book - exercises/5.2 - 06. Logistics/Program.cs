using System;

namespace _5._2___06._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int tons = 0;
            int bus = 0;
            int truck = 0;
            int train = 0;
            double sumTransport = 0;

            double priceBus = 0;
            double priceTruck = 0;
            double priceTrain = 0;
            double priceSumTransport = 0;
            double averagePrice = 0;

            for (int i = 0; i < n; i++)
            {
                tons = int.Parse(Console.ReadLine());

                if (tons <= 3)
                {
                    bus += tons;
                }
                else if (tons <= 11)
                {
                    truck += tons;
                }
                else
                {
                    train += tons;
                }
            }
            priceBus = bus * 200;
            priceTruck = truck * 175;
            priceTrain = train * 120;
            sumTransport = bus + truck + train;

            priceSumTransport = priceBus + priceTruck + priceTrain;

            averagePrice = priceSumTransport / sumTransport;

            Console.WriteLine("{0:f2}", averagePrice);
            Console.WriteLine("{0:f2}%", bus / sumTransport * 100);
            Console.WriteLine("{0:f2}%", truck / sumTransport * 100);
            Console.WriteLine("{0:f2}%", train / sumTransport * 100);
        }
    }
}

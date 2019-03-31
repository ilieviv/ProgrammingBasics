using System;

namespace _01._Sea_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyFood = decimal.Parse(Console.ReadLine());
            decimal moneySouvenirs = decimal.Parse(Console.ReadLine());
            decimal moneyHotel = decimal.Parse(Console.ReadLine());

            decimal fuelExpenses = 2 * 7 * 2.1m * 1.85m;
            decimal foodExpenses = 3 * moneyFood;
            decimal souvenirExpenses = 3 * moneySouvenirs;

            decimal hotelExpenses = (moneyHotel - (moneyHotel * 0.1m)) + (moneyHotel - (moneyHotel * 0.15m)) + (moneyHotel - (moneyHotel * 0.2m));

            decimal total = fuelExpenses + foodExpenses + souvenirExpenses + hotelExpenses;
            Console.WriteLine($"Money needed: {total:f2}");

        }
    }
}

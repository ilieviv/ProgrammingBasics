using System;

namespace _08._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            days -= 1;
            string room = Console.ReadLine().ToLower();
            string review = Console.ReadLine().ToLower();

            double pricePerson = 18;
            double priceApartment = 25;
            double pricePresident = 35;
            double sum = 0;

            if (days < 10)
            {
                priceApartment -= priceApartment * 0.30;
                pricePresident -= pricePresident * 0.10;
            }
            else if (days >= 10 && days <= 15)
            {
                priceApartment -= priceApartment * 0.35;
                pricePresident -= pricePresident * 0.15;
            }
            else if (days > 15)
            {
                priceApartment -= priceApartment * 0.50;
                pricePresident -= pricePresident * 0.20;
            }

            if (room == "room for one person")
            {
                sum = pricePerson * days;
            }
            else if (room == "apartment")
            {
                sum = priceApartment * days;
            }
            else if (room == "president apartment")
            {
                sum = pricePresident * days;
            }

            if (review == "positive")
            {
                sum += sum * 0.25;
            }
            else
            {
                sum -= sum * 0.10;
            }
            Console.WriteLine("{0:f2}", sum);
        }
    }
}

using System;

namespace _08._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceApartment = 0;
            double sumStudio = 0;
            double sumApartment = 0;

            if (month == "May" || month == "October")
            {
                priceStudio = 50;
                priceApartment = 65;

                if (days > 7 && days <= 14)
                {
                    priceStudio -= priceStudio * 0.05;
                }
                else if (days > 14)
                {
                    priceStudio -= priceStudio * 0.30;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = 75.20;
                priceApartment = 68.70;
                if (days > 14)
                {
                    priceStudio -= priceStudio * 0.20;
                }
            }
            else if (month == "July" || month == "August")

            {
                priceStudio = 76;
                priceApartment = 77;
            }

            if (days > 14)
            {
                priceApartment -= priceApartment * 0.10;
            }

            sumStudio = priceStudio * days;
            sumApartment = priceApartment * days;
            Console.WriteLine("Apartment: {0:f2} lv.", sumApartment);
            Console.WriteLine("Studio: {0:f2} lv.", sumStudio);

        }
    }
}

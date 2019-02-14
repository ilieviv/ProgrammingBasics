using System;

namespace _4._2___05._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            double discount = 0;
            double discountApartment = 0;
            double priceApartment = 0;
            double priceStudio = 0;
            double totalApartment = 0;
            double totalStudio = 0;


            if (n > 7 && n < 14)
            {
                discount = 0.05;
            }
            else if (n > 14 && (month == "May" || month == "October"))
            {
                discount = 0.30;
            }
            else if (n > 14 && (month == "June" || month == "September"))
            {
                discount = 0.20;
            }

            if (n > 14)
            {
                discountApartment = 0.10;
            }

            if (month == "May" || month == "October")
            {
                priceApartment = 65;
                priceStudio = 50;
            }
            else if (month == "June" || month == "September")
            {
                priceApartment = 68.70;
                priceStudio = 75.20;
            }
            else if (month == "July" || month == "August")
            {
                priceApartment = 77;
                priceStudio = 76;
            }

            totalApartment = (priceApartment*n) - (n*priceApartment * discountApartment);
            totalStudio = (priceStudio*n) - (n*priceStudio * discount);


            Console.WriteLine("Apartment: {0:f2} lv.", totalApartment);
            Console.WriteLine("Studio: {0:f2} lv.", totalStudio);
        }
    }
}

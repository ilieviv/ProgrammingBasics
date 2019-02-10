using System;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cake = int.Parse(Console.ReadLine());
            int goffret = int.Parse(Console.ReadLine());
            int pancake = int.Parse(Console.ReadLine());

            double priceCake = 45;
            double priceGoffret = 5.80;
            double pricePancake = 3.20;

            double totalCakes = days * confectioners * cake * priceCake;
            double totalGoffrets = days * confectioners *goffret * priceGoffret;
            double totalPancakes = days * confectioners * pancake * pricePancake;

            double income = totalCakes + totalGoffrets + totalPancakes;
            double sumCampaign = income - (income * 0.125);

            Console.WriteLine($"{sumCampaign:f2}");


        }
    }
}

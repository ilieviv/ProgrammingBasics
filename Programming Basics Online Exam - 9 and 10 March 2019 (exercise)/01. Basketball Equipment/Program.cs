using System;

namespace _01._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());

            double priceShoes = tax-(0.4 * tax);
            double priceEkip = priceShoes-(0.2 * priceShoes);
            double priceBall = 0.25 * priceEkip;
            double priceAccessories = 0.2 * priceBall;

            double total = priceShoes + priceEkip + priceBall + priceAccessories+tax;
            Console.WriteLine("{0:f2}", total);
        }
    }
}

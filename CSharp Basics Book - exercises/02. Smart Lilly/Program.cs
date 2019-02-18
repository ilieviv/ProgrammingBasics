using System;

namespace _02._Smart_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double priceWasher = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            int toys = 0;
            double money = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    money = money + (i / 2) * 10;
                    money -= 1;
                }
                else
                {
                    toys++;
                }
            }

            money += priceToy * toys;

            if (money >=priceWasher)
            {
                Console.WriteLine("Yes! {0:f2}", money - priceWasher);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", priceWasher - money);
            }
            
        }
    }
}

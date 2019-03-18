using System;

namespace _09._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal washPrice = decimal.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            decimal money = 0;
            int toys = 0;
            int toysSum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    money += (i * 10) / 2;
                    money -= 1;
                }
                else
                {
                    toys += 1;
                }
            }

            toysSum = toys * toyPrice;
            money += toysSum;

            if (money >= washPrice)
            {
                Console.WriteLine("Yes! {0:f2}", money - washPrice);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", washPrice - money);
            }

        }
    }
}

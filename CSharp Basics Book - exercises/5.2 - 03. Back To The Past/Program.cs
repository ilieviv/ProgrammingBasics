using System;

namespace _5._2___03._Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            int stayYears = year - 1800;
            int moneySpent = 0;

            for (int i = 0; i <= stayYears; i++)
            {
                if (i % 2 == 0)
                {
                    moneySpent += 12000; 
                }
                else
                {
                    moneySpent += 12000 + 50 * (18 + i);
                }

            }

            if (moneySpent <= money)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", money - moneySpent);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", moneySpent - money);
            }

        }
    }
}

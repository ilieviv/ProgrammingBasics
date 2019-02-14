using System;

namespace _4._2___04._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double priceTicket=0;
            double moneyLeft;
            double ticketsSum;
            double leftBudget=0;
            double difference;

            if (people >= 1 && people <=4)
            {
                leftBudget = 0.75 * budget;
            }
            else if (people >= 5 && people <= 9)
            {
                leftBudget = 0.60 * budget;
            }
            else if (people >= 10 && people <= 24)
            {
                leftBudget = 0.50 * budget;
            }
            else if (people >= 25 && people <= 49)
            {
                leftBudget = 0.40 * budget;
            }
            else if (people >= 50)
            {
                leftBudget = 0.25 * budget;
            }

            if (category == "VIP")
            {
                priceTicket = 499.99;
            }
            else if (category == "Normal")
            {
                priceTicket = 249.99;
            }

            moneyLeft = budget - leftBudget;

            ticketsSum = priceTicket * people;

            difference = moneyLeft - ticketsSum;

            if (difference >=0)
            {
                Console.WriteLine($"Yes! You have {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):f2} leva.");
            }


          

        }
    }
}

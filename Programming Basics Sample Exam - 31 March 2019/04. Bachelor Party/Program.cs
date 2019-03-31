using System;

namespace _04._Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceMusician = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int guestsCounter = 0;
            int priceCouvert = 0;
            int sumGroup = 0;
            int total = 0;

            while (command != "The restaurant is full")
            {
                int guests = int.Parse(command);

                if (guests < 5)
                {
                    priceCouvert = 100;
                }
                else
                {
                    priceCouvert = 70;
                }

                sumGroup = priceCouvert * guests;
                total += sumGroup;
                guestsCounter += guests;

                command = Console.ReadLine();
            }

            if (total - priceMusician >= 0)
            {
                Console.WriteLine($"You have {guestsCounter} guests and {total - priceMusician} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {guestsCounter} guests and {total} leva income, but no singer.");
            }
        }
    }
}

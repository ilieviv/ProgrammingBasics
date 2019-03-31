using System;

namespace _03._Sushi_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushi = Console.ReadLine();
            string restaurant = Console.ReadLine();
            int portions = int.Parse(Console.ReadLine());
            char delivery = char.Parse(Console.ReadLine());

            double price = 0;

            switch (sushi)
            {
                case "sashimi":
                    switch (restaurant)
                    {
                        case "Sushi Zone": price = 4.99; break;
                        case "Sushi Time": price = 5.49; break;
                        case "Sushi Bar": price = 5.25; break;
                        case "Asian Pub": price = 4.5; break;
                        default: break;
                    }; break;
                case "maki":
                    switch (restaurant)
                    {
                        case "Sushi Zone": price = 5.29; break;
                        case "Sushi Time": price = 4.69; break;
                        case "Sushi Bar": price = 5.55; break;
                        case "Asian Pub": price = 4.8; break;
                        default: break;
                    }; break;
                case "uramaki":
                    switch (restaurant)
                    {
                        case "Sushi Zone": price = 5.59; break;
                        case "Sushi Time": price = 4.49; break;
                        case "Sushi Bar": price = 6.25; break;
                        case "Asian Pub": price = 5.5; break;
                        default: break;
                    }; break;
                case "temaki":
                    switch (restaurant)
                    {
                        case "Sushi Zone": price = 4.29; break;
                        case "Sushi Time": price = 5.19; break;
                        case "Sushi Bar": price = 4.75; break;
                        case "Asian Pub": price = 5.5; break;
                        default: break;
                    }; break;
                default: break;
            }

            double total = portions * price;

            if (delivery == 'Y')
            {
                total *= 1.2;
            }
            if (price == 0)
            {
                Console.WriteLine($"{restaurant} is invalid restaurant!");
            }
            else
            {
                Console.WriteLine($"Total price: {Math.Ceiling(total)} lv.");
            }
        }
    }
}

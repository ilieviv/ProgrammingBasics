using System;

namespace _03._World_Snooker_Championship
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            char picture = char.Parse(Console.ReadLine());

            double priceTicket = 0;
            double totalPrice = 0;
            bool promotion = false;

            switch (stage)
            {
                case "Quarter final":
                    switch (ticketType)
                    {
                        case "Standard": priceTicket = 55.5; break;
                        case "Premium": priceTicket = 105.2; break;
                        case "VIP": priceTicket = 118.9; break;
                        default: break;
                    }
                    break;
                case "Semi final":
                    switch (ticketType)
                    {
                        case "Standard": priceTicket = 75.88; break;
                        case "Premium": priceTicket = 125.22; break;
                        case "VIP": priceTicket = 300.4; break;
                        default: break;
                    }
                    break;
                case "Final":
                    switch (ticketType)
                    {
                        case "Standard": priceTicket = 110.10; break;
                        case "Premium": priceTicket = 160.66; break;
                        case "VIP": priceTicket = 400; break;
                        default: break;
                    }
                    break;
                default: break;
            }

            totalPrice = tickets * priceTicket;

            if (totalPrice > 2500 && totalPrice <= 4000)
            {
                totalPrice -= totalPrice * 0.1;
            }
            else if (totalPrice > 4000)
            {
                totalPrice -= totalPrice * 0.25;
                promotion = true;
            }


            if (picture == 'Y' && promotion == false)
            {
                totalPrice += (tickets * 40);
            }

            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}

using System;

namespace _04._Cinema_Voucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int voucher = int.Parse(Console.ReadLine());
            string input = string.Empty;

            int ticketsCount = 0;
            int otherCount = 0;

            int priceTicket = 0;
            int priceOther = 0;

            int total = 0;

            while (input != "End")
            {
                input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                if (input.Length > 8)
                {
                    priceTicket = input[0] + input[1];
                    total += priceTicket;
                    if (total > voucher)
                    {
                        break;
                    }
                    ticketsCount++;
                }
                else
                {
                    priceOther = input[0];
                    total += priceOther;
                    if (total > voucher)
                    {
                        break;
                    }
                    otherCount++;
                }
            }

            Console.WriteLine(ticketsCount);
            Console.WriteLine(otherCount);
        }
    }
}

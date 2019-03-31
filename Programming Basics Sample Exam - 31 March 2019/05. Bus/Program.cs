using System;

namespace _05._Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengersStart = int.Parse(Console.ReadLine());
            int stops = int.Parse(Console.ReadLine());

            for (int i = 1; i <= stops; i++)
            {
                int passengersOut = int.Parse(Console.ReadLine());
                int passengersIn = int.Parse(Console.ReadLine());

                if (i % 2 == 1)
                {
                    passengersIn += 2;
                }
                else
                {
                    passengersIn -= 2;
                }

                passengersStart = passengersStart - passengersOut + passengersIn;
            }

            Console.WriteLine($"The final number of passengers is : {passengersStart}");
        }
    }
}

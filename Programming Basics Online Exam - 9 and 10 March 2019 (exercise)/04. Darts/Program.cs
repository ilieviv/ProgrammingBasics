using System;

namespace _04._Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            string input = string.Empty;
            int result = 301;
            int failCounter = 0;
            int successCounter = 0;

            while (input != "Retire" && result != 0)
            {
                input = Console.ReadLine();
                if (input == "Retire")
                {
                    break;
                }
                int points = int.Parse(Console.ReadLine());

                if (input == "Double")
                {
                    points *= 2;
                }
                else if (input == "Triple")
                {
                    points *= 3;
                }

                if (result - points < 0)
                {
                    failCounter++;
                    continue;
                }
                result -= points;
                successCounter++;

                if (result == 0)
                {
                    failCounter = 0;
                }
            }
            if (failCounter != 0)
            {
                Console.WriteLine($"{playerName} retired after {failCounter} unsuccessful shots.");
            }
            else
            {
                Console.WriteLine($"{playerName} won the leg with {successCounter} shots.");
            }
        }
    }
}

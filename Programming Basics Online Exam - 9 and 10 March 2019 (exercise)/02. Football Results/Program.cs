using System;

namespace _02._Football_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string third = Console.ReadLine();

            int teamWon = 0;
            int teamLost = 0;
            int draw = 0;

            if (first[0] > first[2])
            {
                teamWon++;
            }
            else if (first[0] < first[2])
            {
                teamLost++;
            }
            else
            {
                draw++;
            }

            if (second[0] > second[2])
            {
                teamWon++;
            }
            else if (second[0] < second[2])
            {
                teamLost++;
            }
            else
            {
                draw++;
            }

            if (third[0] > third[2])
            {
                teamWon++;
            }
            else if (third[0] < third[2])
            {
                teamLost++;
            }
            else
            {
                draw++;
            }

            Console.WriteLine("Team won {0} games.", teamWon);
            Console.WriteLine("Team lost {0} games.", teamLost);
            Console.WriteLine("Drawn games: {0}", draw);
        }
    }
}

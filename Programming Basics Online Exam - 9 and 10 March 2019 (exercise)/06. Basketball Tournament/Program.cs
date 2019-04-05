using System;

namespace _06._Basketball_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int counterWon = 0;
            int counterLost = 0;

            while (input != "End of tournaments")
            {
                input = Console.ReadLine();

                if (input == "End of tournaments")
                {
                    break;
                }

                int matchesNumber = int.Parse(Console.ReadLine());

                for (int i = 1; i <= matchesNumber; i++)
                {
                    int pointsDesi = int.Parse(Console.ReadLine());
                    int pointsSecond = int.Parse(Console.ReadLine());

                    if (pointsDesi >= pointsSecond)
                    {
                        Console.WriteLine($"Game {i} of tournament {input}: win with {pointsDesi - pointsSecond} points.");
                        counterWon++;
                    }
                    else
                    {
                        Console.WriteLine($"Game {i} of tournament {input}: lost with {pointsSecond - pointsDesi} points.");
                        counterLost++;
                    }
                }
            }

            double win = counterWon / (double)(counterWon + counterLost) * 100;
            double lost = counterLost / (double)(counterWon + counterLost) * 100;

            Console.WriteLine($"{win:f2}% matches win");
            Console.WriteLine($"{lost:f2}% matches lost");
        }
    }
}

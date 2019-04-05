using System;

namespace _05._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());

            int winCount = 0;
            int points = startPoints;

            for (int i = 1; i <= tournaments; i++)
            {
                string stage = Console.ReadLine();

                if (stage == "W")
                {
                    points += 2000;
                    winCount++;
                }
                else if (stage == "F")
                {
                    points += 1200;
                }
                else if (stage == "SF")
                {
                    points += 720;
                }
            }
            double wins = ((double)winCount / tournaments) * 100;

            Console.WriteLine($"Final points: {points}" + Environment.NewLine + $"Average points: {(points - startPoints) / tournaments}" + Environment.NewLine + $"{wins:f2}%");
        }
    }
}

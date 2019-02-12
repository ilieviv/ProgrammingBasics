using System;

namespace _3._2___03._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeTime = int.Parse(Console.ReadLine());

            int workTime = 365 - freeTime;

            int playTime = (workTime * 63) + (freeTime*127);

            if (playTime>30000)
            {
                Console.WriteLine("Tom will run away");
                int aboveNorm = playTime - 30000;

                int h = aboveNorm / 60;
                int m = aboveNorm % 60;

                Console.WriteLine($"{h} hours and {m} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                int belowNorm = 30000 - playTime;

                int h = belowNorm / 60;
                int m = belowNorm % 60;

                Console.WriteLine($"{h} hours and {m} minutes less for play");
            }

        }
    }
}

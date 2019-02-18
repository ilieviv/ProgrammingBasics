using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int sum = hour * 60 + minutes;
            int hourNew = sum / 60;
            int minNew = (sum % 60) + 15;

            if (minNew >= 60)
            {
                hourNew += 1;
                minNew = minNew % 60;
            }

            if (hourNew == 24)
            {
                hourNew = 0;
            }

            if (minNew < 10)
            {
                Console.WriteLine("{0}:0{1}", hourNew, minNew);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hourNew, minNew);
            }
           
        }

    }
}

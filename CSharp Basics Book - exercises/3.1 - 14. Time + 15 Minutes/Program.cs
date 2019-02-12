using System;

namespace _3._1___14._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes>=60)
            {
                hour += 1;
                if (hour==24)
                {
                    hour = 0;
                }
                minutes = minutes % 60;

                if (minutes <10)
                {
                    Console.WriteLine($"{hour}:0{minutes}");
                }
                else
                {
                    Console.WriteLine($"{hour}:{minutes}");
                }
            }
            else
            {
                if (minutes < 10)
                {
                    Console.WriteLine($"{hour}:0{minutes}");
                }
                else
                {
                    Console.WriteLine($"{hour}:{minutes}");
                }
            }

        }
    }
}

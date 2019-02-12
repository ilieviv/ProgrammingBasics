using System;

namespace _3._1___07._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum = a + b + c;

            int minutes = sum / 60;
            int sec = sum % 60;

            if (sec < 10)
            {
                Console.WriteLine($"{minutes}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{sec}");
            }
        }
    }
}

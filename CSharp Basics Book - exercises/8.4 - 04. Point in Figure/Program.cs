using System;

namespace _8._4___04._Point_in_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool horizontal = x >= 4 && x <= 10 && y >= -5 && y <= 3;
            bool vertical = x >= 2 && x <= 12 && y >= -3 && y <= 1;
            if (horizontal || vertical)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}

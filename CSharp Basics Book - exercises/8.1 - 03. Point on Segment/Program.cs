using System;

namespace _8._1___03._Point_on_Segment
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            int distance = Math.Min(Math.Abs(point - first), Math.Abs(point - second));

            int firstMin = Math.Min(first, second);
            int secondMax = Math.Max(first, second);

            if (point >= firstMin && point <= secondMax)
            {
                Console.WriteLine("in\n" + distance);
            }
            else
            {
                Console.WriteLine("out\n" + distance);
            }
        }
    }
}

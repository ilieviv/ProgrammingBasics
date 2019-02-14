using System;

namespace _4._1___06._Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            var leftSide = (y >= y1 && y <= y2) && (x == x1);
            var rightSide = (y >= y1 && y <= y2) && (x == x2);
            var upSide = (x >= x1 && x <= x2) && (y == y2);
            var downSide = (x >= x1 && x <= x2) && (y == y1);


            if (leftSide||rightSide||upSide||downSide)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }

        }
    }
}

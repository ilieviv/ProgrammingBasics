using System;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x = Math.Abs(x1 -y1);
            double y = Math.Abs(x2 - y2);

            double perimeter = 2 * (x + y);
            double area = x * y;

            Console.WriteLine("{0:f2}", area);
            Console.WriteLine("{0:f2}", perimeter);

        }
    }
}

using System;

namespace _10___05._Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine(Area(a, h));
        }
        static double Area(double a, double h)
        {
            return a * h / 2;
        }

    }
}

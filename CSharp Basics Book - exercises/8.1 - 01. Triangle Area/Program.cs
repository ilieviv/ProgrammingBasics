using System;

namespace _8._1___01._Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            double a = Math.Abs(x3 - x2);
            double h = Math.Abs(y1 - y2);
            double area = a * h / 2;
            Console.WriteLine("{0}", area);
        }
    }
}

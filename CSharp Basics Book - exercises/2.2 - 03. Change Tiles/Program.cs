using System;

namespace _2._2___03._Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());
            double tileChange = 0.2;

            double wholeArea = n * n;
            double bench = m * o;
            double tilesArea = wholeArea - bench;

            double tileArea = w * l;

            double tileQuantity = tilesArea / tileArea;

            double tileTime = tileQuantity * tileChange;

            Console.WriteLine(tileQuantity);
            Console.WriteLine(tileTime);




        }
    }
}

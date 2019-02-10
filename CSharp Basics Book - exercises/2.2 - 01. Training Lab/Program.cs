using System;

namespace _2._2___01._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            //double hallwayArea = l;
            //double hallArea = l * w;

            //double workSpaceArea = 0.7 * 1.2;
            //double doorArea = workSpaceArea;
            //double cathedreArea = 1.6 * 1.2;

            //double freeSpace = hallArea - hallwayArea - cathedreArea - doorArea;

            //double freeSpace = hallArea - hallwayArea;
            //double desktops = freeSpace / workSpaceArea;

            double columns = Math.Floor((w - 1) / 0.7);
            double rows = Math.Floor(l / 1.2);

            double desks = (columns * rows)-3;


            Console.WriteLine(desks);

        }
    }
}

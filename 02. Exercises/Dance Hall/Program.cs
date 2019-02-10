using System;

namespace Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
                       
            double roomArea = l * w;
            double wardrobeArea = a * a;
            double benchArea = roomArea / 10;

            double dancerArea = 0.004;
            double dancerMovingArea = 0.7;
            double dancerWholeArea = dancerArea + dancerMovingArea;

            double freeArea = roomArea - wardrobeArea - benchArea;

            double maxDancers = freeArea / dancerWholeArea;

            Console.WriteLine(Math.Floor(maxDancers));

        }
    }
}

using System;

namespace _3._2___02._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            //double d1 = double.Parse(Console.ReadLine());
            //double d2 = double.Parse(Console.ReadLine());

            //double d3 = d1 + d2;
            //Console.WriteLine(Math.Ceiling(d3));

            double v = double.Parse(Console.ReadLine());
            double p1 = double.Parse(Console.ReadLine());
            double p2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double vEnd = (p1  + p2) * h;
            
            double p1Percent = (p1 * h) / vEnd * 100;
            double p2Percent = (p2 * h) / vEnd * 100;

            double vPercent = vEnd / v * 100;

            if (vEnd<=v)
            {
                Console.WriteLine($"The pool is {Math.Truncate(vPercent)}% full. Pipe 1: {Math.Truncate(p1Percent)}%. Pipe 2: {Math.Truncate(p2Percent)}%.");
            }
            else if (vEnd>v)
            {
                double vOverflow = vEnd - v;
                Console.WriteLine($"For {h} hours the pool overflows with {vOverflow} liters.");
            }


        }
    }
}

using System;

namespace _8._2___01._Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = int.Parse(Console.ReadLine());
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdtTime = int.Parse(Console.ReadLine());


            double firstLine = speed * (firstTime / 60d);
            speed *= 1.1;

            double secondLine = speed * (secondTime / 60d);
            speed -= speed * 0.05;

            double trhidLine = speed * (thirdtTime / 60d);

            double total = firstLine + secondLine + trhidLine;
            Console.WriteLine("{0:f2}", total);
        }
    }
}

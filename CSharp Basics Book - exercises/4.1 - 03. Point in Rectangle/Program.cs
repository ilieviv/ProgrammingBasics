using System;

namespace _4._1__
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

            bool state = false;

            if (x >= x1 && x <= x2)
            {
                if (y >= y1 & y <= y2)
                {
                    state = true;
                }
                else
                {
                    state = false;
                }

            }

            if (state == true)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}

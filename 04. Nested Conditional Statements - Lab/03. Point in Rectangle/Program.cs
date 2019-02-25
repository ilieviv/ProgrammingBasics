using System;

namespace _03._Point_in_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());

            if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
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

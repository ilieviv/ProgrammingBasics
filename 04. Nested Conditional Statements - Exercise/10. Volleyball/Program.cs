using System;

namespace _10._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double inSofia = (3.0 / 4.0) * (48 - h);
            double holidays = (2.0 / 3.0) * p;
            double total = inSofia + holidays + h;

            if (year == "leap")
            {
                total += total * 0.15;
            }
            Console.WriteLine(Math.Floor(total));
        }
    }
}

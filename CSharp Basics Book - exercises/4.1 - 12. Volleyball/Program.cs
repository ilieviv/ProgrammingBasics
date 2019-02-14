using System;

namespace _4._1___12._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double sofia = (48.0 - h) * 3.0 / 4.0;
            double holidays = p*(2.0 / 3.0);
            double play=sofia+holidays+h;

            switch (year)
            {
                case "leap": play = play * 1.15; Console.WriteLine(Math.Truncate(play)); break;
                case "normal": Console.WriteLine(Math.Truncate(play)); break;
                default:
                    break;
            }
        }
    }
}

using System;

namespace _03._Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string tool = Console.ReadLine();

            double total = 0;

            switch (country)
            {
                case "Bulgaria":
                    switch (tool)
                    {
                        case "ribbon": total = 9.6 + 9.4; break;
                        case "hoop": total = 9.55 + 9.75; break;
                        case "rope": total = 9.5 + 9.4; break;
                        default: break;
                    }
                    break;
                case "Russia":
                    switch (tool)
                    {
                        case "ribbon": total = 9.1 + 9.4; break;
                        case "hoop": total = 9.3 + 9.8; break;
                        case "rope": total = 9.6 + 9; break;
                        default: break;
                    }
                    break;
                case "Italy":
                    switch (tool)
                    {
                        case "ribbon": total = 9.2 + 9.5; break;
                        case "hoop": total = 9.45 + 9.35; break;
                        case "rope": total = 9.7 + 9.15; break;
                        default: break;
                    }
                    break;
            }

            double percent = (20 - total) / 20 * 100;

            Console.WriteLine($"The team of {country} get {total:f3} on {tool}.");
            Console.WriteLine("{0:f2}%", percent);
        }
    }
}

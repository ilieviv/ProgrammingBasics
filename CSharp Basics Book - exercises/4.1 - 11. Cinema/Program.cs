using System;

namespace _4._1___11._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projecton = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            switch (projecton)
            {
                case "Premiere": Console.WriteLine("{0:f2}", 12*r*c); break;
                case "Normal": Console.WriteLine("{0:f2}", 7.5 * r * c); break;
                case "Discount": Console.WriteLine("{0:f2}", 5 * r * c); break;
                default:
                    break;
            }
        }
    }
}

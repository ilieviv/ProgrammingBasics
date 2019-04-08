using System;

namespace _03._Oscars_week_in_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            string hallType = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            double price = 0;

            switch (movieName)
            {
                case "A Star Is Born":
                    switch (hallType)
                    {
                        case "normal": price = 7.5; break;
                        case "luxury": price = 10.5; break;
                        case "ultra luxury": price = 13.5; break;
                        default: break;
                    }
                    break;
                case "Bohemian Rhapsody":
                    switch (hallType)
                    {
                        case "normal": price = 7.35; break;
                        case "luxury": price = 9.45; break;
                        case "ultra luxury": price = 12.75; break;
                        default: break;
                    }
                    break;
                case "Green Book":
                    switch (hallType)
                    {
                        case "normal": price = 8.15; break;
                        case "luxury": price = 10.25; break;
                        case "ultra luxury": price = 13.25; break;
                        default: break;
                    }
                    break;
                case "The Favourite":
                    switch (hallType)
                    {
                        case "normal": price = 8.75; break;
                        case "luxury": price = 11.55; break;
                        case "ultra luxury": price = 13.95; break;
                        default: break;
                    }
                    break;
                default: break;
            }

            double total = (double)tickets * (double)price;
            Console.WriteLine($"{movieName} -> {total:f2} lv.");
        }
    }
}

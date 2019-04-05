using System;

namespace _05._Fitness_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            int visitors = int.Parse(Console.ReadLine());

            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int shake = 0;
            int bar = 0;
            double workout = 0;
            double protein = 0;

            for (int i = 0; i < visitors; i++)
            {
                string activity = Console.ReadLine();

                switch (activity)
                {
                    case "Back": back++; break;
                    case "Chest": chest++; break;
                    case "Legs": legs++; break;
                    case "Abs": abs++; break;
                    case "Protein shake": shake++; break;
                    case "Protein bar": bar++; break;
                    default:
                        break;
                }
            }

            workout = ((back + chest + legs + abs) / (double)visitors) * 100;
            protein = 100 - workout;

            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{shake} - protein shake");
            Console.WriteLine($"{bar} - protein bar");
            Console.WriteLine($"{workout:f2}% - work out");
            Console.WriteLine($"{protein:f2}% - protein");
        }
    }
}

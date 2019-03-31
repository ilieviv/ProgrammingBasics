using System;

namespace _02._Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double averageHeight = double.Parse(Console.ReadLine());

            double spacecraftArea = width * height * length;
            double roomArea = 2 * 2 * (averageHeight + 0.4);

            double availableArea = spacecraftArea / roomArea;

            double astronauts = Math.Floor(availableArea);

            if (astronauts < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (astronauts > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
            else
            {
                Console.WriteLine($"The spacecraft holds {astronauts} astronauts.");
            }

        }
    }
}

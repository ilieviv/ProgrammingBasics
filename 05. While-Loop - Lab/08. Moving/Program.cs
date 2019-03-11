using System;

namespace _08._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int room = width * length * height;
            int volume = 0;
            int carton = 0;
            bool exit = false;

            while (volume < room)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    if (volume > room)
                    {
                        Console.WriteLine("No more free space! You need {0} Cubic meters more.", volume - room);
                        exit = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("{0} Cubic meters left.", room - volume);
                        exit = true;
                        break;
                    }
                }
                else
                {
                    carton = int.Parse(input);
                    volume += carton;
                }


            }

            if (volume > room && exit == false)
            {
                Console.WriteLine("No more free space! You need {0} Cubic meters more.", volume - room);
            }
            else if (volume <= room && exit == false)
            {
                Console.WriteLine("{0} Cubic meters left.", room - volume);
            }

        }
    }
}

using System;

namespace _05._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int widht = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int cake = widht * lenght;
            int parts = 0;
            int takeParts = 0;

            string command = string.Empty;

            while (command != "STOP")
            {
                command = Console.ReadLine();

                if (command == "STOP")
                {
                    break;
                }

                takeParts = int.Parse(command);
                parts += takeParts;

                if (parts > cake)
                {
                    Console.WriteLine("No more cake left! You need {0} pieces more.", parts - cake);
                    break;
                }
            }

            if (command == "STOP")
            {
                Console.WriteLine("{0} pieces are left.", cake - parts);
            }

        }
    }
}

using System;

namespace _6._2___01._Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //TOP part
            Console.Write('/');
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('^');
            }
            Console.Write('\\');

            for (int i = 0; i < 2 * n - 2 * n / 2 - 4; i++)
            {
                Console.Write('_');
            }

            Console.Write('/');
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('^');
            }
            Console.Write('\\');


            //Middle part
            Console.WriteLine();

            for (int i = 0; i < n - 3; i++)
            {
                Console.Write('|');
                for (int j = 0; j < 2 * n - 2; j++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine('|');

            }
            Console.Write('|');
            Console.Write(new string(' ', (n / 2) ));
            Console.Write(new string('_', 2 * n - 2 * n / 2 - 4));
            Console.Write(new string(' ', (n / 2) ));
            Console.WriteLine('|');

            //Bottom part
            Console.Write('\\');
            for (int i = 0; i < 2 * n - 2 * n / 2 - 4; i++)
            {
                Console.Write('_');
            }
            Console.Write('/');

            for (int i = 0; i < 2 * n - 2 * n / 2 - 4; i++)
            {
                Console.Write(' ');
            }

            Console.Write('\\');
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('_');
            }
            Console.Write('/');
        }
    }
}

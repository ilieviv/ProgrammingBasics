using System;

namespace _07._Safe_Passwords_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int counter = 0;
            int A = 35;
            int B = 64;
            int x = 1;
            int y = 1;

            while (counter < max)
            {
                //ABxyBA
                Console.Write($"{(char)A}{(char)B}{x}{y}{(char)B}{(char)A}|");
                A++;
                B++;
                y++;

                if (y > b)
                {
                    x++;
                    y = 1;
                }

                if (A > 55)
                {
                    A = 35;
                }

                if (B > 96)
                {
                    B = 64;
                }


                if (x == a && y == b)
                {
                    Console.Write($"{(char)A}{(char)B}{x}{y}{(char)B}{(char)A}|");
                    break;
                }
                counter++;
            }
            Console.WriteLine();
        }
    }
}

using System;

namespace _6._1___05._Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("+ ");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");

            for (int row = 2; row <= n - 1; row++)
            {
                Console.Write("| ");
                for (int col = 1; col <= n - 2; col++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }

            Console.Write("+ ");
            for (int l = 1; l <= n - 2; l++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
        }
    }
}

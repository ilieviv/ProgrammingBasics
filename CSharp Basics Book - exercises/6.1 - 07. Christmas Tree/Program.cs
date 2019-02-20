using System;

namespace _6._1___07._Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.Write(' ');
            }
            Console.WriteLine('|');

            for (int row = 1; row <= n; row++)
            {
                for (int i = 0; i < n - row; i++)
                {
                    Console.Write(' ');
                }

                for (int i = 1; i <= row; i++)
                {
                    Console.Write('*');
                }

                Console.Write(" | ");

                for (int i = 1; i <= row; i++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }
        }
    }
}

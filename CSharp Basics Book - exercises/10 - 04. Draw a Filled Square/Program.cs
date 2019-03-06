using System;

namespace _10___04._Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Lines(n);

            for (int i = 0; i < n - 2; i++)
            {
                Middle(n);
            }

            Lines(n);
        }

        static void Lines(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void Middle(int n)
        {
            Console.Write('-');
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.Write('-');
            Console.WriteLine();
        }
    }
}

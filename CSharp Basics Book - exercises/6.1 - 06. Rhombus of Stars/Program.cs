using System;

namespace _6._1___06._Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int f = 1; f <= n; f++)
            {
                for (int r = 0; r < n - f; r++)
                {
                    Console.Write(' ');
                }

                for (int c = 0; c < f; c++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int l = n - 1; l > 0; l--)
            {
                for (int r = n - l; r > 0; r--)
                {
                    Console.Write(' ');
                }

                for (int c = 0; c < l; c++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


        }
    }
}

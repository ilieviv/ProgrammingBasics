using System;

namespace _6._2___05._Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', n * 3), new string('-', i), new string('-', n * 2 - 2 - i));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}", new string('*', n * 3), new string('-', n - 1));
            }

            for (int i = 0; i < n / 2; i++)
            {
                if (i == n / 2 - 1)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', n * 3 - i), new string('*', n - 1 + 2 * i), new string('-', n - 1 - i));
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', n * 3 - i), new string('-', n - 1 + 2 * i), new string('-', n - 1 - i));
                }

            }
        }
    }
}


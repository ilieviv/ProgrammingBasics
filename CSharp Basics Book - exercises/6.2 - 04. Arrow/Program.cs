using System;

namespace _6._2___04._Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('#', n));

            for (int i = 0; i < n - 1; i++)
            {
                if (i < n - 2)
                {
                    Console.WriteLine("{0}#{1}#{0}", new string('.', n / 2), new string('.', n - 2));
                }
                else
                {
                    Console.WriteLine("{0}#{1}#{0}", new string('#', n / 2), new string('.', n - 2));
                }

            }
            for (int i = 1; i < n - 1; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', i), new string('.', 2 * n - 3 - 2 * i));
            }
            Console.WriteLine("{0}#{0}", new string('.', n - 1));

        }
    }
}

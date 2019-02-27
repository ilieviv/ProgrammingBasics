using System;

namespace _6._2___03._Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var row = 2 * n + 2;

            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', 2 * n + 1));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', n - i), new string('_', 2 * n - 1 + 2 * i));
            }

            //MIDDLE STOP
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', n * 2 - 3));

            //BOTTOM
            for (int i = n; i > 0; i--)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', n - i), new string('_', 2 * n - 1 + 2 * i));
            }
        }
    }
}

using System;

namespace _6._2___01._Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var col = n / 2;
            var row = n;
            var size = 2 * n - 2 * col - 4;

            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', col), new string('_', size));

            for (int i = 1; i < n - 2; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
            }

            Console.WriteLine("|{0}{1}{0}|", new string(' ', col + 1), new string('_', size));

            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', col), new string(' ', size));
        }
    }
}

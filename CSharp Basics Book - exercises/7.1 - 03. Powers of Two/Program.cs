using System;

namespace _7._1___03._Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(num);
                num *= 2;
            }

        }
    }
}

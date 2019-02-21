using System;

namespace _7._1___05._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            while (num <= n)
            {
                Console.WriteLine(num);
                num = 2 * num + 1;
            }
        }
    }
}

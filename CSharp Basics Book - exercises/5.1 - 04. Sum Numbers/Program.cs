using System;

namespace _5._1___04._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int newN = 0;
            int sum = 0;
            for (int i = 1; i <=n; i++)
            {
                newN = int.Parse(Console.ReadLine());
                sum += + newN;
            }
            Console.WriteLine(sum);
        }
    }
}

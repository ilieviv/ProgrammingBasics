using System;

namespace _10___09._Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int minFirst = GetMin(n1, n2);
            int minFromThree = GetMin(minFirst, n3);
            Console.WriteLine(minFromThree);
        }

        static int GetMin(int a, int b)
        {
            int minNumber = Math.Min(a, b);
            return minNumber;
        }
    }

}
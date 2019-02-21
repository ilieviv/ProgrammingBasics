using System;

namespace _7._1___06._Number_in_Range__1to100_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n < 1 || n > 100)
            {
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is: {0}: ", n);
        }
    }
}

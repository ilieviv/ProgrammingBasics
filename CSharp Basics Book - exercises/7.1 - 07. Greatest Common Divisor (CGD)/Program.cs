using System;

namespace _7._1___07._Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (b != 0)
            {
                var oldB = b;
                b = a % b;
                a = oldB;
            }
            Console.WriteLine("GCD = {0}", a);
        }
    }
}

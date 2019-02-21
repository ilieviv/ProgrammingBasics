using System;

namespace _7._1___09._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0;

            do
            {
                var nOst = n % 10;
                sum += nOst;
                n = n / 10;

            } while (n > 0);
            Console.WriteLine(sum);
        }
    }
}

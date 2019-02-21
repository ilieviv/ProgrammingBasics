using System;

namespace _7._1___08._Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var factorial = 1;

            do
            {
                factorial *= n;
                n--;
            } while (n>1);
            Console.WriteLine(factorial);
        }
    }
}

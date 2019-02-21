using System;

namespace _7._1___10._Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n > 1)
            {
                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }
            }
            else
            {
                Console.WriteLine("Not prime");
            }


        }
    }
}

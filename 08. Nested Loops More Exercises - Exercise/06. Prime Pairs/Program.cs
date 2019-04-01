using System;

namespace _06._Prime_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int diffFirst = int.Parse(Console.ReadLine());
            int diffLast = int.Parse(Console.ReadLine());

            bool isPrime = true;

            for (int first = n1; first <= n1 + diffFirst; first++)
            {
                for (int second = n2; second <= n2 + diffLast; second++)
                {
                    for (int i = 2; i <= Math.Ceiling(Math.Sqrt(first)); i++)
                    {
                        if (first % i == 0)
                        {
                            isPrime = false;

                        }
                    }

                    for (int j = 2; j <= Math.Ceiling(Math.Sqrt(second)); j++)
                    {
                        if (second % j == 0)
                        {
                            isPrime = false;

                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine($"{first}{second}");
                    }

                    isPrime = true;
                }
            }
        }
    }
}

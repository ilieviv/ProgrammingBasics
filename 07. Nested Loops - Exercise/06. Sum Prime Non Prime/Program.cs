using System;

namespace _06._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int primeCounter = 0;
            int notPrimeCounter = 0;

            while (input != "stop")
            {
                int num = int.Parse(input);

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                bool isPrime = true;

                if (num == 1)
                {
                    isPrime = false;
                }
                else
                {
                    double limit = Math.Ceiling(Math.Sqrt(num));

                    for (int i = 2; i <= limit; i++)
                    {
                        if (num % i == 0 && i != num)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    primeCounter += num;
                }
                else
                {
                    notPrimeCounter += num;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeCounter}" + Environment.NewLine + $"Sum of all non prime numbers is: {notPrimeCounter}");
        }
    }
}

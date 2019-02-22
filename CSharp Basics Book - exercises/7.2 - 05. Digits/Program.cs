using System;

namespace _7._2___05._Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var numCopy = num;
            int d3 = numCopy % 10;
            numCopy /= 10;
            int d2 = numCopy % 10;
            numCopy /= 10;
            int d1 = numCopy % 10;

            for (int i = 0; i < d1 + d2; i++)
            {
                for (int j = 0; j < d1 + d3; j++)
                {
                    if (num % 5 == 0)
                    {
                        num -= d1;
                        Console.Write("{0} ", num);
                    }
                    else if (num % 3 == 0)
                    {
                        num -= d2;
                        Console.Write("{0} ", num);
                    }
                    else
                    {
                        num += d3;
                        Console.Write("{0} ", num);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

using System;

namespace _5._1___11._Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double sumOdd = 0;
            double minOdd = double.MaxValue;
            double maxOdd = double.MinValue;

            double sumEven = 0;
            double minEven = double.MaxValue;
            double maxEven = double.MinValue;


            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven += number;
                    minEven = Math.Min(minEven, number);
                    maxEven = Math.Max(maxEven, number);
                    //if (number < minEven)
                    //{
                    //    minEven = number;
                    //}

                    //if (number > maxEven)
                    //{
                    //    maxEven = number;
                    //}
                }
                else
                {
                    sumOdd += number;
                    minOdd = Math.Min(minOdd, number);
                    maxOdd = Math.Max(maxOdd, number);
                    //if (number < minOdd)
                    //{
                    //    minOdd = number;
                    //}

                    //if (number > maxOdd)
                    //{
                    //    maxOdd = number;
                    //}
                }

            }

                Console.WriteLine("OddSum = " + sumOdd);

            if (minOdd==double.MaxValue)
            {
                Console.WriteLine("oddMin = No");
            }
            else
            {
                Console.WriteLine("OddMin = " + minOdd);
            }

            if (maxOdd == double.MinValue)
            {
                Console.WriteLine("oddMax = No");
            }
            else
            {
                Console.WriteLine("OddMax = " + maxOdd);
            }
                Console.WriteLine("EvenSum = " + sumEven);               

            if (minEven == double.MaxValue)
            {
                Console.WriteLine("EvenMin = No");
            }
            else
            {
                Console.WriteLine("EvenMin = " + minEven);
            }

            if (maxEven == double.MinValue)
            {
                Console.WriteLine("EvenMax = No");
            }
            else
            {
                Console.WriteLine("EvenMax = " + maxEven);
            }

        }
    }
}

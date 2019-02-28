using System;

namespace _8._1___07._Sums_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    var number = int.Parse(Console.ReadLine());
            //    if (i % 3 == 1)
            //    {
            //        sum1 += number;
            //    }
            //    if (i % 3 == 2)
            //    {
            //        sum2 += number;
            //    }

            //    if (i % 3 == 0)
            //    {
            //        sum3 += number;
            //    }
            //}

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i+=3)
            {
                sum1 += numbers[i];
            }
            for (int i = 1; i < numbers.Length; i += 3)
            {
                sum2 += numbers[i];
            }
            for (int i = 2; i < numbers.Length; i += 3)
            {
                sum3 += numbers[i];
            }
            Console.WriteLine("sum1 = " + sum1);
            Console.WriteLine("sum2 = " + sum2);
            Console.WriteLine("sum3 = " + sum3);
 
        }
    }
}

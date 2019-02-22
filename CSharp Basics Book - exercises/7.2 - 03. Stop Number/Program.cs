using System;

namespace _7._2___03._Stop_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            do
            {
                if (m % 2 == 0 && m % 3 == 0)
                {
                    if (m == s)
                    {
                        break;
                    }
                    Console.Write("{0} ", m);
                }
                m--;
            } while (m >= n);
            Console.WriteLine();

            //for (int i = m; i >= n; i--)
            //{
            //    if (i%2==0 && i%3==0)
            //    {
            //        if (i==s)
            //        {
            //            break;
            //        }
            //        Console.Write("{0} ", i);
            //    }
            //}
            //Console.WriteLine();
        }
    }
}

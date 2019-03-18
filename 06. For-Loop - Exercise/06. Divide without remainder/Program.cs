using System;

namespace _06._Divide_without_remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double counter = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                counter++;

                if (num % 2 == 0)
                {
                    p1++;
                }

                if (num % 3 == 0)
                {
                    p2++;
                }

                if (num % 4 == 0)
                {
                    p3++;
                }
            }

            p1 = (p1 / counter) * 100;
            p2 = (p2 / counter) * 100;
            p3 = (p3 / counter) * 100;

            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
        }
    }
}

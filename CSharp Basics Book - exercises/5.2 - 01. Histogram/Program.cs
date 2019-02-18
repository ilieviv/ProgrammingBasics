using System;

namespace _5._2___01._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] < 200)
                {
                    p1 += 1;
                }
                else if (a[i] >= 200 && a[i] < 400)
                {
                    p2 += 1;
                }
                else if (a[i] >= 400 && a[i] < 600)
                {
                    p3 += 1; 
                }
                else if (a[i] >= 600 && a[i] < 800)
                {
                    p4 += 1;
                }
                else if (a[i] >= 800)
                {
                    p5 += 1;
                }
            }
            
            Console.WriteLine("{0:f2}%", p1/n*100);
            Console.WriteLine("{0:f2}%", p2/n*100);
            Console.WriteLine("{0:f2}%", p3/n*100);
            Console.WriteLine("{0:f2}%", p4/n*100);
            Console.WriteLine("{0:f2}%", p5/n*100);
        }
    }
}

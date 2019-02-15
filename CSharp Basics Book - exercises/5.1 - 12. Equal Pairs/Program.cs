using System;

namespace _5._1___12._Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int difference = 0;
            int maxDifference = 0;

            for (int i = 1; i <= n; i++)
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                difference = Math.Abs(sum - (n2 + n1));
                
                if (maxDifference>difference)
                {
                    maxDifference = difference;
                }
                sum = (n1 + n2);
             
            }

            if (n == 1)
            {
                Console.WriteLine("Yes, value=" + sum);
            }
            else if (difference==0)
            {
                Console.WriteLine("Yes, value=" + sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff=" + difference);
            }

           
        }
    }
}

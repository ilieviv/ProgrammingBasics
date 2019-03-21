using System;

namespace _02._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int current = 1;
            bool bigger = false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (current > n)
                    {
                        bigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }

                if (bigger)
                {
                    break;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

using System;

namespace _7._1___16._Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    num = row + col + 1;
                    if (num > n)
                    {
                        num = (2 * n) - num;
                    }
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

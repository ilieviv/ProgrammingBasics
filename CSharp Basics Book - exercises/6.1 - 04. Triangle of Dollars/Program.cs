using System;

namespace _6._1___04._Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int l = 0; l <=i; l++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}

using System;

namespace _5._1___06._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int isMin = Int32.MaxValue;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number < isMin)
                {
                    isMin = number;
                }

            }

            Console.WriteLine(isMin);
        }
    }
}

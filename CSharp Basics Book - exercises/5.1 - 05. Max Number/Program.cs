using System;

namespace _5._1___05._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int isMax = Int32.MinValue;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number >isMax)
                {
                    isMax = number;
                }

            }

            Console.WriteLine(isMax);

        }
    }
}

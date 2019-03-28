using System;

namespace _01._Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n2 < 2 && n2 > 8)
            {
                return;
            }

            for (int i = 1; i <= n1; i++)
            {
                for (int j = 2; j <= n2; j++)
                {
                    for (int k = 1; k <= n3; k++)
                    {
                        bool condition = i % 2 == 0 && k % 2 == 0;
                        bool conditionPrime = j == 2 || j == 3 || j == 5 || j == 7;
                        if (condition && conditionPrime)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}

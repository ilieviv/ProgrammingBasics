using System;

namespace _01._Secret_Door_s_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            bool prime = false;

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    for (int k = 1; k <= c; k++)
                    {
                        if (j == 2 || j == 3 || j == 5 || j == 7)
                        {
                            prime = true;
                        }
                        else
                        {
                            prime = false;
                        }
                        bool condition = i % 2 == 0 && k % 2 == 0 && prime;

                        if (condition)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}

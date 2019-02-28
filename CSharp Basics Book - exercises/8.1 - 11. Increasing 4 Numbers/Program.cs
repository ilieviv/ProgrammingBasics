using System;

namespace _8._1___11._Increasing_4_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = i + 1; j <= b; j++)
                {
                    for (int k = j + 1; k <= b; k++)
                    {
                        for (int l = k + 1; l <= b; l++)
                        {
                            Console.WriteLine("{0} {1} {2} {3}", i, j, k, l);
                            counter++;
                        }
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}

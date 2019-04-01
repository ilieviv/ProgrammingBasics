using System;

namespace _04._HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double total = 0;
            double totalAll = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 1; j <= hours; j++)
                    {
                        if (j % 2 == 0)
                        {
                            total += 1;
                        }
                        else
                        {
                            total += 2.5d;
                        }
                    }
                }
                else
                {
                    for (int j = 1; j <= hours; j++)
                    {
                        if (j % 2 == 0)
                        {
                            total += 1.25;
                        }
                        else
                        {
                            total += 1;
                        }
                    }
                }

                Console.WriteLine($"Day: {i} - {total:f2} leva");
                totalAll += total;
                total = 0;
            }
            Console.WriteLine("Total: {0:f2} leva", totalAll);
        }
    }
}

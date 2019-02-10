using System;

namespace _1___04._Triangle_of_55_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //55 stars on 10 rows

            for (int i = 1; i <= 10; i++)
            {
                for (int n = 0; n < i; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}

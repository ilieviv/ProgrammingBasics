using System;

namespace _6._1___01._Rectangle_of_10_x_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int l = 0; l < 10; l++)
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new string('*', 10));
            }
        }
    }
}

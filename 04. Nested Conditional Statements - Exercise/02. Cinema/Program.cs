using System;

namespace _02._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine().ToLower();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            double price = 0;

            if (projection=="premiere")
            {
                price = 12;
            }
            else if (projection=="normal")
            {
                price = 7.5;
            }
            else if (projection=="discount")
            {
                price = 5;
            }

            double sum = price * row * col;
            Console.WriteLine("{0:f2} leva", sum);
        }
    }
}

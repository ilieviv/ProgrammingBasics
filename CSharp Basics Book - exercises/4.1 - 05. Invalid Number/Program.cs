using System;

namespace _4._1___05._Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            var inRange = (n >= 100 && n <= 200) || n == 0;
            {
                if (!inRange)
                {
                    Console.WriteLine("invalid");
                }
            }
        }
    }
}

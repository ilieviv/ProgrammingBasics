using System;

namespace _06._Three_brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            double work = 1 / (1/a + 1/b + 1/c);
            work *= 1.15;

            double difference = Math.Abs(Math.Ceiling(work - d));

            Console.WriteLine("Cleaning time: {0:f2}", work);

            if (d>work)
            {
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", difference);
            }
            else
            { 
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", difference);
            }
           
            
        }
    }
}

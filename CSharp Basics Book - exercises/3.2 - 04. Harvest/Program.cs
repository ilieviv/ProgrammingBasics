using System;

namespace _3._2___04._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double grape = 0.4 * x * y;
            double vine = grape / 2.5;
            double difference = Math.Abs(vine-z);


            if (vine < z)
            {

                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(difference));
            }
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(vine));
                double vineWorker = difference / n;
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(difference), Math.Ceiling(vineWorker));


            }
        }
    }
}

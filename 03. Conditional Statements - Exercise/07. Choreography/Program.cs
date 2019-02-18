using System;

namespace _07._Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            double allStepsDay = (n / days) / n * 100;
            allStepsDay = Math.Ceiling(allStepsDay);
            double percentStepsDancer = (allStepsDay / dancers);


            if (allStepsDay < 13)
            {
                Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%.", percentStepsDancer);
            }
            else
            {
                Console.WriteLine("No, they will not succeed in that goal! Required {0:f2}% steps to be learned per day.", percentStepsDancer);
            }



        }
    }
}

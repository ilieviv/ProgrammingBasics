using System;

namespace _08._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine());

            double waterFactor = Math.Truncate(meters / 15);
            waterFactor = waterFactor * 12.5;

            double distance = meters * speed + waterFactor;

            if (distance < record)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", distance);
            }
            else
            {
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", distance-record);
            }
        }
    }
}

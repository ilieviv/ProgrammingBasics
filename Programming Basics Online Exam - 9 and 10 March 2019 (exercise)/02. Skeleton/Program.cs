using System;

namespace _02._Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesControl = int.Parse(Console.ReadLine());
            int secondsControl = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            int secondsHundredMeters = int.Parse(Console.ReadLine());

            int totalControl = (minutesControl * 60) + secondsControl;
            double minusTime = (length / 120) * 2.5;
            double timeMarin = (length / 100) * secondsHundredMeters - minusTime;

            if (timeMarin <= totalControl)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!" + Environment.NewLine + $"His time is {timeMarin:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {(timeMarin - totalControl):f3} second slower.");
            }
        }
    }
}

using System;

namespace _09._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int arrivingHour = int.Parse(Console.ReadLine());
            int arrivingMinutes = int.Parse(Console.ReadLine());

            int examInMinutes = hour * 60 + minutes;
            int arriveInMinutes = arrivingHour * 60 + arrivingMinutes;

            int difference = examInMinutes - arriveInMinutes;

            if (difference == 0)
            {
                Console.WriteLine("On time");
            }
            else if (difference >= 0 && difference <= 30)
            {
                Console.WriteLine("On time \n{0} minutes before the start", difference);
            }
            else if (difference > 30 && difference < 60)
            {
                Console.WriteLine("Early \n{0} minutes before the start", difference);
            }
            else if (difference >= 60)
            {
                arrivingHour = difference / 60;
                arrivingMinutes = difference % 60;
                if (arrivingMinutes < 10)
                {
                    Console.WriteLine("Early \n{0}:0{1} hours before the start", arrivingHour, arrivingMinutes);
                }
                else
                {
                    Console.WriteLine("Early \n{0}:{1} hours before the start", arrivingHour, arrivingMinutes);
                }

            }
            else if (difference < 0 && difference > -60)
            {
                Console.WriteLine("Late \n{0} minutes after the start", Math.Abs(difference));
            }
            else
            {
                arrivingHour = arrivingHour - hour;
                arrivingMinutes = arrivingMinutes % 60;
                if (arrivingMinutes < 10)
                {
                    Console.WriteLine("Late \n{0}:0{1} hours after the start", arrivingHour, arrivingMinutes);
                }
                else
                {
                    Console.WriteLine("Late \n{0}:{1} hours after the start", arrivingHour, arrivingMinutes);
                }
            }
        }
    }
}

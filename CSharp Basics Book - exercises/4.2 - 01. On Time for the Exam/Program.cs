using System;

namespace _4._2___01._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivingHour = int.Parse(Console.ReadLine());
            int arrivingMinutes = int.Parse(Console.ReadLine());

            int examToMinutes = examHour * 60 + examMinutes;
            int arrivingToMinutes = arrivingHour * 60 + arrivingMinutes;
            int difference = examToMinutes - arrivingToMinutes;

            int hour, min;

            if (difference<=30 && difference>=0)
            {
                if (difference==0)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time {0} minutes before the start", difference);
                }
                
            }
            else if (difference > 30)
            {
                hour = difference / 60;
                min = difference % 60;
                if (hour < 1)
                {
                    Console.WriteLine("Early {0} minutes before the start", difference);
                }
                else
                {
                    if (min <10)
                    {
                        Console.WriteLine("Early {0}:0{1} hours before the start", hour, min);
                    }
                    else
                    {
                        Console.WriteLine("Early {0}:{1} hours before the start", hour, min);
                    }
                    
                }               
            }
            else
            {
                difference = Math.Abs(difference);
                hour = difference / 60;
                min = difference % 60;
                if (hour < 1)
                {
                    Console.WriteLine("Late {0} minutes after the start", difference);
                }
                else
                {
                    if (min < 10)
                    {
                        Console.WriteLine("Late {0}:0{1} hours after the start", hour, min);
                    }
                    else
                    {
                        Console.WriteLine("Late {0}:{1} hours after the start", hour, min);
                    }

                }
            }
        }
    }
}

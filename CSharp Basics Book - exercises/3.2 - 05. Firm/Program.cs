using System;

namespace _3._2___05._Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double workDays = 0.9 * days;

            double overtime = 2 * workDays * workers;
            double workHours = Math.Floor(workers*workDays * 8 + overtime);



         
            if (workHours >= hours)
            {
                Console.WriteLine("Yes!{0} hours left.", workHours-hours);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", hours-workHours);
            }
        }

    }
}

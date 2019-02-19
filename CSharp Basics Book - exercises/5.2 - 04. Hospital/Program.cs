using System;

namespace _5._2___04._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int examinedPatients = 0;
            int notExaminedPatients = 0;
            int doctors = 7;
            int todayPatients = 0;

            for (int i = 1; i <= period; i++)
            {
                todayPatients = int.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    if (notExaminedPatients > examinedPatients)
                    {
                        doctors++;
                    }
                }

                if (todayPatients > doctors)
                {
                    examinedPatients += doctors;
                    notExaminedPatients += todayPatients - doctors;
                }
                else
                {
                    examinedPatients += todayPatients;
                }

            }
            Console.WriteLine("Treated patients: {0}.", examinedPatients);
            Console.WriteLine("Untreated patients: {0}.", notExaminedPatients);

        }
    }
}

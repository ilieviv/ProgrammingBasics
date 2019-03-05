using System;

namespace _9._1___01._Crossing_sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int t1 = int.Parse(Console.ReadLine());
            int t2 = int.Parse(Console.ReadLine());
            int t3 = int.Parse(Console.ReadLine());
            int s1 = int.Parse(Console.ReadLine());
            int s2 = int.Parse(Console.ReadLine());

            int sCurrent = s1;

            int tFirst = t1;
            int tSecond = t2;
            int tThird = t3;
            int tCurrent = t1;

            int counter = 0;
            int multi = 0;

            bool found = false;

            while (sCurrent <= 1000000 && tCurrent <= 1000000)
            {
                if (tCurrent == sCurrent)
                {
                    Console.WriteLine(tCurrent); found = true; break;
                }
                else if (tCurrent < sCurrent)
                {
                    tCurrent = tFirst + tSecond + tThird;
                    tFirst = tSecond;
                    tSecond = tThird;
                    tThird = tCurrent;
                }
                else
                {
                    if (counter % 2 == 0)
                    {
                        multi++;
                    }
                    sCurrent = s1 + s2 * multi;
                    s1 = sCurrent;
                    counter++;
                }

            }

            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}

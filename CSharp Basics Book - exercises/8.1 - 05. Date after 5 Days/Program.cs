using System;

namespace _8._1___05._Date_after_5_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int newDay = d + 5;

            if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10)
            {
                if (newDay > 31)
                {
                    newDay = newDay - 31;
                    m += 1;
                    if (m < 10)
                    {
                        Console.WriteLine("{0}.0{1}", newDay, m);
                    }
                    else
                    {
                        Console.WriteLine("{0}.{1}", newDay, m);
                    }
                }
                else
                {
                    if (m < 10)
                    {
                        Console.WriteLine("{0}.0{1}", newDay, m);
                    }
                    else
                    {
                        Console.WriteLine("{0}.{1}", newDay, m);
                    }
                }
            }
            else if (m == 12)
            {
                if (newDay > 31)
                {
                    newDay = newDay - 31;
                    m = 1;
                    Console.WriteLine("{0}.0{1}", newDay, m);
                }
                else
                {
                    if (m < 10)
                    {
                        Console.WriteLine("{0}.0{1}", newDay, m);
                    }
                    else
                    {
                        Console.WriteLine("{0}.{1}", newDay, m);
                    }
                }
            }
            else if (m == 2)
            {
                if (newDay > 28)
                {
                    newDay = newDay - 28;
                    m += 1;
                    Console.WriteLine("{0}.0{1}", newDay, m);
                }
                else
                {
                    Console.WriteLine("{0}.0{1}", newDay, m);
                }
            }
            else
            {
                if (newDay > 30)
                {
                    newDay = newDay - 30;
                    m += 1;
                    if (m < 10)
                    {
                        Console.WriteLine("{0}.0{1}", newDay, m);
                    }
                    else
                    {
                        Console.WriteLine("{0}.{1}", newDay, m);
                    }
                }
                else
                {
                    if (m < 10)
                    {
                        Console.WriteLine("{0}.0{1}", newDay, m);
                    }
                    else
                    {
                        Console.WriteLine("{0}.{1}", newDay, m);
                    }
                }
            }
        }
    }
}

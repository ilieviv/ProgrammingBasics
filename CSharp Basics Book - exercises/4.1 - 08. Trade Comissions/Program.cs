using System;

namespace _4._1___08._Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double s = double.Parse(Console.ReadLine());

            double commission=0;
            

            if (s>=0&&s<=500)
            {
                if (city == "Sofia")
                {
                    commission = s * 0.05;
                }
                else if (city == "Varna")
                {
                    commission = s * 0.045;
                }
                else if (city == "Plovdiv")
                {
                    commission = s * 0.055;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (s >= 500 && s <= 1000)
            {
                if (city == "Sofia")
                {
                    commission = s * 0.07;
                }
                else if (city == "Varna")
                {
                    commission = s * 0.075;
                }
                else if (city == "Plovdiv")
                {
                    commission = s * 0.08;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (s >= 1000 && s <= 10000)
            {
                if (city == "Sofia")
                {
                    commission = s * 0.08;
                }
                else if (city == "Varna")
                {
                    commission = s * 0.1;
                }
                else if (city == "Plovdiv")
                {
                    commission = s * 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (s >10000)
            {
                if (city == "Sofia")
                {
                    commission = s * 0.12;
                }
                else if (city == "Varna")
                {
                    commission = s * 0.13;
                }
                else if (city == "Plovdiv")
                {
                    commission = s * 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.WriteLine("{0:f2}", commission);
        }
    }
}

using System;

namespace _07._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double comission = 0;
            double sum = 0;

            if (city == "sofia")
            {
                if (quantity > 0 && quantity <= 500)
                {
                    comission = 0.05;
                }
                else if (quantity > 500 && quantity <= 1000)
                {
                    comission = 0.07;
                }
                else if (quantity > 1000 && quantity <= 10000)
                {
                    comission = 0.08;
                }
                else
                {
                    comission = 0.12;
                }
            }
            else if (city == "varna")
            {
                if (quantity > 0 && quantity <= 500)
                {
                    comission = 0.045;
                }
                else if (quantity > 500 && quantity <= 1000)
                {
                    comission = 0.075;
                }
                else if (quantity > 1000 && quantity <= 10000)
                {
                    comission = 0.10;
                }
                else if (quantity > 10000)
                {
                    comission = 0.13;
                }

            }
            else if (city == "plovdiv")
            {
                if (quantity > 0 && quantity <= 500)
                {
                    comission = 0.055;
                }
                else if (quantity > 500 && quantity <= 1000)
                {
                    comission = 0.08;
                }
                else if (quantity > 1000 && quantity <= 10000)
                {
                    comission = 0.12;
                }
                else if (quantity > 10000)
                {
                    comission = 0.145;
                }
            }

            sum = quantity * comission;
            if (sum > 0)
            {

                Console.WriteLine("{0:f2}", sum);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}

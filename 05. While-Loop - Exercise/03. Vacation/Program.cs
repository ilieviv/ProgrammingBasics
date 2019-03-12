using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetExcursion = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            //double saving = 0;
            int counterSpend = 0;
            int counterDays = 0;
            bool failSaving = false;

            while (budget < budgetExcursion && counterSpend < 5)
            {
                string action = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());

                counterDays++;

                if (action == "spend")
                {
                    if (amount > budget)
                    {
                        budget = 0;
                    }
                    else
                    {
                        budget -= amount;
                    }

                    counterSpend++;

                    if (counterSpend == 5)
                    {
                        failSaving = true;
                        break;
                    }
                }
                else if (action == "save")
                {
                    budget += amount;
                    counterSpend = 0;
                }
            }

            if (failSaving)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(counterDays);
            }
            else
            {
                Console.WriteLine("You saved the money for {0} days.", counterDays);
            }


        }
    }
}

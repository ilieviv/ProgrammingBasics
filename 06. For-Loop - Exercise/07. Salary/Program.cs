using System;

namespace _07._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            bool lost = false;

            for (int i = 0; i < tabs; i++)
            {
                string tab = Console.ReadLine();

                if (tab == "Facebook")
                {
                    salary -= 150;
                }
                else if (tab == "Instagram")
                {
                    salary -= 100;
                }
                else if (tab == "Reddit")
                {
                    salary -= 50;
                }

                if (salary <= 0)
                {
                    lost = true;
                    break;
                }
            }

            if (lost)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}

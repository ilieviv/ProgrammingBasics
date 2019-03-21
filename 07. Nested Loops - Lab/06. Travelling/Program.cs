using System;

namespace _06._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            // double budget = double.Parse(Console.ReadLine());


            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double savings = 0;

                while (savings < budget)
                {
                    savings += double.Parse(Console.ReadLine());

                }

                Console.WriteLine("Going to {0}!", destination);
                destination = Console.ReadLine();
            }
        }
    }
}

using System;

namespace _08._Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int counter = 0;
            double sum = 0;
            double total = 0;

            while (input != "Stop" && counter < n)
            {
                counter++;

                if (input == "Stop")
                {
                    break;
                }
                double kg = double.Parse(Console.ReadLine());

                for (int i = 0; i < input.Length; i++)
                {
                    sum += input[i];
                }

                sum /= kg;

                if (counter % 3 == 0)
                {
                    total += sum;
                }
                else
                {
                    total -= sum;
                }
                sum = 0;
                input = Console.ReadLine();
            }

            if (counter == n)
            {
                Console.WriteLine("Lyubo fulfilled the quota!");
            }
            if (total < 0)
            {
                Console.WriteLine("Lyubo lost {0:f2} leva today.", Math.Abs(total));
            }
            else
            {
                Console.WriteLine("Lyubo's profit from {0} fishes is {1:f2} leva.", counter, total);
            }
        }
    }
}

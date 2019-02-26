using System;

namespace _04._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int flowersQuantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double sum = 0;

            if (flowersType == "Roses")
            {
                sum = flowersQuantity * 5;
                if (flowersQuantity > 80)
                {
                    sum -= sum * 0.1;
                }
            }
            else if (flowersType == "Dahlias")
            {
                sum = flowersQuantity * 3.80;
                if (flowersQuantity > 90)
                {
                    sum -= sum * 0.15;
                }
            }
            else if (flowersType == "Tulips")
            {
                sum = flowersQuantity * 2.80;
                if (flowersQuantity > 80)
                {
                    sum -= sum * 0.15;
                }
            }
            else if (flowersType == "Narcissus")
            {
                sum = flowersQuantity * 3;
                if (flowersQuantity < 120)
                {
                    sum += sum * 0.15;
                }
            }
            else if (flowersType == "Gladiolus")
            {
                sum = flowersQuantity * 2.50;
                if (flowersQuantity < 80)
                {
                    sum += sum * 0.20;
                }
            }
            double difference = Math.Abs(budget - sum);

            if (sum > budget)
            {
                Console.WriteLine("Not enough money, you need {0:f2} leva more.", difference);
            }
            else
            {
                Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", flowersQuantity, flowersType, difference);
            }
        }
    }
}

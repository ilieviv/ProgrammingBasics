using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string metricIn = Console.ReadLine();
            string metricOut = Console.ReadLine();

            double result = 0;

            if (metricIn == "mm")
            {
                if (metricOut == "cm")
                {
                    result = number / 10;
                }
                else if (metricOut == "m")
                {
                    result = number / 1000;
                }
            }
            else if (metricIn == "cm")
            {
                if (metricOut == "mm")
                {
                    result = number * 10;
                }
                else if (metricOut == "m")
                {
                    result = number / 100;
                }
            }
            else if (metricIn == "m")
            {
                if (metricOut == "mm")
                {
                    result = number * 1000;
                }
                else if (metricOut == "cm")
                {
                    result = number * 100;
                }
            }

            Console.WriteLine("{0:f3}", result);
        }
    }
}

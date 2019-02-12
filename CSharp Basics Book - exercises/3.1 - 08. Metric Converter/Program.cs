using System;

namespace _3._1___08._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string inM = Console.ReadLine();
            string outM = Console.ReadLine();

            if (inM == "mm")
            {
                n = n / 1000;
            }
            else if (inM == "cm")
            {
                n = n / 100;
            }
            else if (inM == "mi")
            {
                n = n / 0.000621371192;
            }
            else if (inM == "in")
            {
                n = n / 39.3700787;
            }
            else if (inM == "km")
            {
                n = n / 0.001;
            }
            else if (inM == "ft")
            {
                n = n / 3.2808399;
            }
            else if (inM == "yd")
            {
                n = n / 1.0936133;
            }


            if (outM == "mm")
            {
                n = n * 1000;
            }
            else if (outM == "cm")
            {
                n = n * 100;
            }
            else if (outM == "mi")
            {
                n = n * 0.000621371192;
            }
            else if (outM == "in")
            {
                n = n * 39.3700787;
            }
            else if (outM == "km")
            {
                n = n * 0.001;
            }
            else if (outM == "ft")
            {
                n = n * 3.2808399;
            }
            else if (outM == "yd")
            {
                n = n * 1.0936133;
            }

            Console.WriteLine(n);


        }
    }
}

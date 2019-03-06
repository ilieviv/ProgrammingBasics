using System;

namespace _10___06._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());


            double result = PowerNumber(number, power);
            Console.WriteLine(result);
        }

        static double PowerNumber(double number, double power)
        {
            double result = 0d;
            result = Math.Pow(number, power);
            return result;
        }
    }
}

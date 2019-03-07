using System;

namespace _10___12._Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long index = long.Parse(Console.ReadLine());

            Console.WriteLine(IntegerToBase(number, index));
        }

        static string IntegerToBase(long number, long index)
        {
            string result = "";

            while (number != 0)
            {
                long remainder = number % index;
                number /= index;
                result = remainder.ToString() + result;

            }
            return result;

        }
    }
}

using System;

namespace _07._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();

            double result = 0;
            string oddEven = string.Empty;

            if (sign == "+")
            {
                result = n1 + n2;
                if (result % 2 == 0)
                {
                    oddEven = "even";
                }
                else
                {
                    oddEven = "odd";
                }
                Console.WriteLine($"{n1} + {n2} = {result} - {oddEven}");
            }
            else if (sign == "-")
            {
                result = n1 - n2;
                if (result % 2 == 0)
                {
                    oddEven = "even";
                }
                else
                {
                    oddEven = "odd";
                }
                Console.WriteLine($"{n1} - {n2} = {result} - {oddEven}");
            }
            else if (sign == "*")
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    oddEven = "even";
                }
                else
                {
                    oddEven = "odd";
                }
                Console.WriteLine($"{n1} * {n2} = {result} - {oddEven}");
            }
            else if (sign == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    result = n1 / (double)n2;
                    Console.WriteLine($"{n1} / {n2} = {result:f2}");
                }
            }
            else if (sign == "%")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    result = n1 % n2;
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }

            }
        }
    }
}

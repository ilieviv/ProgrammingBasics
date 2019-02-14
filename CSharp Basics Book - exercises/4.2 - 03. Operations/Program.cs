using System;

namespace _4._2___03._Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string operand = Console.ReadLine();
            string evOd = string.Empty;
            double sum = 0;

            if (operand.Equals("+"))
            {
                sum = n1 + n2;
                if (sum % 2 == 0)
                {
                    evOd = "even";
                }
                else
                {
                    evOd = "odd";
                }
            }
            else if (operand.Equals("-"))
            {
                sum = n1 - n2;
                if (sum % 2 == 0)
                {
                    evOd = "even";
                }
                else
                {
                    evOd = "odd";
                }
            }
            else if (operand.Equals("*"))
            {
                sum = n1 * n2;
                if (sum % 2 == 0)
                {
                    evOd = "even";
                }
                else
                {
                    evOd = "odd";
                }
            }
            else if (operand.Equals("/"))
            {
                sum = n1 / n2;
            }
            else if (operand.Equals("%"))
            {
                sum = n1 % n2;
            }

            if (n2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
            }
            else
            {
                if (operand.Equals("+") || operand.Equals("-") || operand.Equals("*"))
                {
                    Console.WriteLine($"{n1} {operand} {n2} = {sum} - {evOd}");
                }
                else if (operand.Equals("/"))
                {
                    Console.WriteLine($"{n1} {operand} {n2} = {sum:f2}");
                }
                else if (operand.Equals("%"))
                {
                    Console.WriteLine($"{n1} {operand} {n2} = {sum}");
                }
                string numberIs = result % 2 == 0 ? "even" : "odd";
            }
        }
    }
}

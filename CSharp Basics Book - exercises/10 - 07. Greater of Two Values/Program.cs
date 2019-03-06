using System;

namespace _10___07._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int max = GetMax(a, b);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char max = GetMax(a, b);
                Console.WriteLine(max);
            }
            else
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string max = GetMax(a, b);
                Console.WriteLine(max);
            }
        }
        static int GetMax(int a, int b)
        {
            int max = 0;
            if (a >= b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            return max;
        }

        static char GetMax(char a, char b)
        {

            char max = (char)0x00;
            if (a >= b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            return max;
        }

        static string GetMax(string a, string b)
        {
            string max = string.Empty;
            if (a.CompareTo(b) >= 0)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            return max;
        }
    }
}



using System;

namespace _04._Number_1to_9_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string number = "";

            switch (n)
            {
                case 1: number = "one"; break;
                case 2: number = "two"; break;
                case 3: number = "three"; break;
                case 4: number = "four"; break;
                case 5: number = "five"; break;
                case 6: number = "six"; break;
                case 7: number = "seven"; break;
                case 8: number = "eight"; break;
                case 9: number = "nine"; break;
                default:
                    number = "number too big";
                    break;
            }

            Console.WriteLine(number);
        }
    }
}

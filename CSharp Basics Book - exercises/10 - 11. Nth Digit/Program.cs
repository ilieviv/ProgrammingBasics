using System;

namespace _10___11._Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            FindNthDigit(number, index);
        }

        static void FindNthDigit(int number, int index)
        {
            int counter = 1;

            while (number != 0)
            {

                if (counter == index)
                {
                    number = number % 10;
                    break;
                }
                else
                {
                    number = number / 10;
                }
                counter++;

            }
            Console.WriteLine(number);
        }
    }
}

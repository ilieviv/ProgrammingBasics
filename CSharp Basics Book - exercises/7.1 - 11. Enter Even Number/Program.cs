using System;

namespace _7._1___11._Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The number is not even.");
                }
            }
            Console.WriteLine("Even number entered: {0}", n);
        }
    }
}

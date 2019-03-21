using System;

namespace _07._Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int sum = 0;
            int max = 0;
            string nameWinner = string.Empty;

            while (name != "STOP")
            {
                for (int i = 0; i < name.Length; i++)
                {
                    sum += name[i];
                }

                if (sum > max)
                {
                    max = sum;
                    nameWinner = name;
                }
                sum = 0;
                name = Console.ReadLine();
            }

            Console.WriteLine($"Winner is {nameWinner} - {max}!");
        }
    }
}

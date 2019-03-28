using System;

namespace _02._Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char lastChar = char.Parse(Console.ReadLine());
            char exceptChar = char.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = firstChar; i <= lastChar; i++)
            {
                for (int j = firstChar; j <= lastChar; j++)
                {
                    for (int k = firstChar; k <= lastChar; k++)
                    {
                        if (i != exceptChar && j != exceptChar && k != exceptChar)
                        {
                            Console.Write($"{(char)i}{(char)j}{(char)k} ");
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}

using System;

namespace _02._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            bool isMagic = false;
            int counter = 0;

            for (int i = startInterval; i <= endInterval; i++)
            {
                for (int j = startInterval; j <= endInterval; j++)
                {
                    counter++;

                    if (i + j == magic)
                    {
                        isMagic = true;
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magic})");
                        return;
                    }

                }
            }

            if (isMagic == false)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
            }
        }
    }
}

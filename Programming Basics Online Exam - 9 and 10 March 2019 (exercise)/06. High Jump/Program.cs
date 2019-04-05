using System;

namespace _06._High_Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            int desire = int.Parse(Console.ReadLine());

            int start = desire - 30;
            int failCount = 0;
            int jumpCounter = 0;

            int jump = 0;
            while (true)
            {
                jump = int.Parse(Console.ReadLine());
                jumpCounter++;

                if (jump <= start)
                {
                    failCount++;
                    if (failCount == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {start}cm after {jumpCounter} jumps.");
                        break;
                    }
                }
                if (jump > start)
                {
                    if (start >= desire)
                    {
                        break;
                    }
                    start += 5;
                    failCount = 0;

                }
            }
            if (jump > desire)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {start}cm after {jumpCounter} jumps.");
            }
        }
    }
}

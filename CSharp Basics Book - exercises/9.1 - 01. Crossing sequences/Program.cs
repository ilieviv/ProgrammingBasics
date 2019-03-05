using System;
using System.Collections.Generic;

namespace _9._1___01._Crossing_sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int t1 = int.Parse(Console.ReadLine());
            int t2 = int.Parse(Console.ReadLine());
            int t3 = int.Parse(Console.ReadLine());
            int s1 = int.Parse(Console.ReadLine());
            int s2 = int.Parse(Console.ReadLine());

            var tribonaciNumbers = new List<int>() { t1, t2, t3 };
            var tribonaciCurrent = t3;

            while (tribonaciCurrent < 1000000)
            {
                tribonaciCurrent = t1 + t2 + t3;
                tribonaciNumbers.Add(tribonaciCurrent);

                t1 = t2;
                t2 = t3;
                t3 = tribonaciCurrent;
            }
            var spiralCurrent = s1;
            var spiralNumbers = new List<int>() { spiralCurrent };
            var spiralCount = 0;
            var spiralStepMul = 1;


            while (spiralCurrent < 1000000)
            {
                spiralCurrent += s2 * spiralStepMul;

                spiralNumbers.Add(spiralCurrent);
                spiralCount++;

                if (spiralCount % 2 == 0)
                {
                    spiralStepMul++;
                }

            }

            var found = false;

            for (int i = 0; i < tribonaciNumbers.Count; i++)
            {
                for (int j = 0; j < spiralNumbers.Count; j++)
                {
                    if (tribonaciNumbers[i] == spiralNumbers[j] && tribonaciNumbers[i] <= 1000000)
                    {
                        Console.WriteLine(tribonaciNumbers[i]);
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("No");
            }

        }
    }
}

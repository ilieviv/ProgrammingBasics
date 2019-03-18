using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            int sum = 0;
            int max = int.MinValue;
            bool equal = false;
            int equalNumber = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (array[i] == sum - array[i])
                {
                    equal = true;
                    equalNumber = array[i];
                }


            }

            if (equal)
            {
                Console.WriteLine("Yes\nSum = {0}", equalNumber);
            }
            else
            {
                Console.WriteLine("No\nDiff = {0}", Math.Abs((sum - max) - max));
            }
        }
    }
}

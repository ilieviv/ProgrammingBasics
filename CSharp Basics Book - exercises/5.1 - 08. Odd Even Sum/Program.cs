using System;

namespace _5._1___08._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                evenSum += i % 2 == 0 ? number : 0;
                oddSum += i % 2 == 1 ? number : 0;
            }
            string result = oddSum == evenSum ?
                $"Yes\nSum = {oddSum}" : $"No\nDiff = {Math.Abs(oddSum - evenSum)}";
            Console.WriteLine(result);

        }
    }
}

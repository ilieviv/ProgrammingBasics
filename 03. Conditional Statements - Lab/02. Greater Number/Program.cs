using System;

namespace _02._Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int result = Math.Max(n1, n2);
            Console.WriteLine(result);
        }
    }
}

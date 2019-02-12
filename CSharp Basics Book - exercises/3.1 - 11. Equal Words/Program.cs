using System;

namespace _3._1___11._Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().ToLower();
            var second = Console.ReadLine().ToLower();

            if (first==second)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

using System;

namespace _10___08._Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, {0}!", Name());
        }

        static string Name()
        {
            string name = Console.ReadLine();
            return name;
        }
    }
}

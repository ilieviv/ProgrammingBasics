using System;

namespace _11._Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "dog")
            {
                Console.WriteLine("mammal");
            }
            else if (input == "crocodile" || input == "tortoise" || input == "snake")
            {
                Console.WriteLine("reptile");
            }
            else 
            {
                Console.WriteLine("unknown");
            }
        }
    }
}

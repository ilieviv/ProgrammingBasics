using System;

namespace _4._1___04._Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToLower();

            if (s =="banana"|| s=="apple"|| s == "kiwi" || s == "cherry" || s == "lemon" || s == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (s =="tomato"|| s == "cucumber" || s == "pepper" || s == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}

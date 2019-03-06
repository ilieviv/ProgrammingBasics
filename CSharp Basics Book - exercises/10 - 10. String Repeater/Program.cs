using System;

namespace _10___10._String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            RepeatString(str, count);
            Console.WriteLine();
        }

        static void RepeatString(string str, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(str);
            }
        }
    }
}

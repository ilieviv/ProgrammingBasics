using System;

namespace _03._Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string num = n.ToString();
            int length = num.Length;

            for (int i = 0; i < length; i++)
            {
                int s1 = n % 10;
                n = n / 10;

                if (s1 == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }

                for (int col = 0; col < s1; col++)
                {

                    Console.Write((char)(s1 + 33));

                }
                Console.WriteLine();
            }


        }
    }
}


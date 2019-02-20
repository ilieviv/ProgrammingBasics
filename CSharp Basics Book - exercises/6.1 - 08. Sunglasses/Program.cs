using System;

namespace _6._1___08._Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int ramka = (n - 1) / 2 - 1;

            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('*');
                Console.Write(new string('/', n * 2 - 2));
                Console.Write('*');

                if (i == ramka)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }

                Console.Write('*');
                Console.Write(new string('/', n * 2 - 2));
                Console.WriteLine('*');

            }

            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));


            //for (int i = 0; i < 2 * n; i++)
            //{
            //    Console.Write('*');
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(" ");
            //}

            //for (int i = 0; i < 2 * n; i++)
            //{
            //    Console.Write('*');
            //}
            //Console.WriteLine();

            ///////////////////////

            //for (int i = 1; i <= n - 2; i++)
            //{
            //    Console.Write('*');
            //    for (int l = 0; l < (n * 2) - 2; l++)
            //    {
            //        Console.Write('/');
            //    }
            //    Console.Write('*');


            //    if (ramka == i)
            //    {
            //        Console.Write(new string('|', n));
            //    }
            //    else
            //    {
            //        Console.Write(new string(' ', n));
            //    }



            //    Console.Write('*');
            //    for (int l = 0; l < (n * 2) - 2; l++)
            //    {
            //        Console.Write('/');
            //    }
            //    Console.Write('*');
            //    Console.WriteLine();
            //}

            ///////////////////////

            //for (int i = 0; i < 2 * n; i++)
            //{
            //    Console.Write('*');
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(" ");
            //}

            //for (int i = 0; i < 2 * n; i++)
            //{
            //    Console.Write('*');
            //}
            //Console.WriteLine();

        }
    }
}

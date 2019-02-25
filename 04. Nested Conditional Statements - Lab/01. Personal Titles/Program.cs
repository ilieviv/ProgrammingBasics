using System;

namespace _01._Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            var sex = Console.ReadLine();

            if (age >= 16)
            {
                switch (sex)
                {
                    case "f": Console.WriteLine("Ms."); break;
                    case "m": Console.WriteLine("Mr."); break;
                    default:
                        break;
                }

            }
            else
            {
                switch (sex)
                {
                    case "f": Console.WriteLine("Miss"); break;
                    case "m": Console.WriteLine("Master"); break;
                    default:
                        break;
                }
            }

        }
    }
}

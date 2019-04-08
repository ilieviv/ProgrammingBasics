using System;

namespace _01._Oscars_ceremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double statue = rent - (rent * 0.3d);
            double catering = statue - (statue * 0.15d);
            double sound = 0.5d * catering;

            double sum = statue + catering + sound + rent;

            Console.WriteLine("{0:f2}", sum);
        }
    }
}

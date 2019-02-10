using System;
using System.Globalization;

namespace _2___13._1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string birth = Console.ReadLine();
            DateTime parseBirth = DateTime.ParseExact(birth, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime hundredDays = parseBirth.AddDays(1000);

            Console.WriteLine(hundredDays.ToString("dd-MM-yyyy"));


            string birthDate = Console.ReadLine();

            ////Days Alive Calculator
            //string birthDate = Console.ReadLine();

            //DateTime parsed = DateTime.ParseExact(birthDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            //DateTime today = DateTime.Now;

            //TimeSpan age = (today - parsed)   

            //Console.WriteLine(age.ToString("%d"));

        }
    }
}

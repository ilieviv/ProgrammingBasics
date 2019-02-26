using System;

namespace _03._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine().ToLower();
            string outfit = "";
            string shoes = "";

            if (temp >= 10 && temp <= 18)
            {
                switch (dayTime)
                {
                    case "morning": outfit = "Sweatshirt"; shoes = "Sneakers"; break;
                    case "afternoon": outfit = "Shirt"; shoes = "Moccasins"; break;
                    case "evening": outfit = "Shirt"; shoes = "Moccasins"; break;
                    default:
                        break;
                }
            }
            else if (temp > 18 && temp <= 24)
            {
                switch (dayTime)
                {
                    case "morning": outfit = "Shirt"; shoes = "Moccasins"; break;
                    case "afternoon": outfit = "T-Shirt"; shoes = "Sandals"; break;
                    case "evening": outfit = "Shirt"; shoes = "Moccasins"; break;
                    default:
                        break;
                }
            }
            else if (temp >= 25)
            {
                switch (dayTime)
                {
                    case "morning": outfit = "T-Shirt"; shoes = "Sandals"; break;
                    case "afternoon": outfit = "Swim Suit"; shoes = "Barefoot"; break;
                    case "evening": outfit = "Shirt"; shoes = "Moccasins"; break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"It's {temp} degrees, get your {outfit} and {shoes}.");

        }
    }
}

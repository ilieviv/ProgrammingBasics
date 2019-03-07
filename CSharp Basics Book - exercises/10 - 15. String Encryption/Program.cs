using System;

namespace _10___15._String_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(global::System.Console.ReadLine());
            Console.WriteLine(string.Join("", Encrypt(n)));
        }

        static string[] Encrypt(int n)
        {
            string[] result = new string[n];

            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());

                byte charByte = (byte)symbol;
                byte firstDigit = 0;
                byte lastDigit = 0;

                if (charByte < 100)
                {
                    firstDigit = (byte)(charByte / 10);
                    lastDigit = (byte)(charByte % 10);
                }
                else
                {
                    firstDigit = (byte)(charByte / 100);
                    lastDigit = (byte)(charByte % 10);
                }

                string middle = firstDigit.ToString() + lastDigit.ToString();

                result[i] += (char)(charByte + lastDigit) + middle + (char)(charByte + firstDigit);

            }
            return result;

        }
    }

}



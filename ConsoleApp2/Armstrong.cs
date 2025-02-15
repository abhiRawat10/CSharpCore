using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpCore
{
    internal class Prime
    {
        public static void Entry()
        {
            Console.WriteLine("Enter a number to check if it is Armstrong or not");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isArmstrong(n));
        }

        public static bool isArmstrong(int n)
        {
            int originalNumber = n, sum = 0, digits = n.ToString().Length;

            while (n > 0)
            {
                int digit = number % 10;
                sum += (int)Math.Pow(digit, digits);
                n /= 10;
            }

            return sum == originalNumber;
        }
    }
}
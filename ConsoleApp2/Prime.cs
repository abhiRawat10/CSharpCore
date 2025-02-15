using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpCore
{
    internal class Prime
    {
        public static void Entry()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isPrime(n));
        }
        public static bool isPrime(int n)
        {
            if (n == 1 || n == 0) return true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

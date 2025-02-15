using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpCore
{
    internal class Prime
    {
        public static void Entry()
        {
            Console.WriteLine("Enter a number to check if it is Positive or not");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0) Console.WriteLine("positive");
            else if (n < 0) Console.WriteLine("negative");
            else Console.WriteLine("Zero"); 
        }
    }
}
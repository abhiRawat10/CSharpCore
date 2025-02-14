using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2;

namespace cSharpCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //example for if else statements
            Console.WriteLine("Enter 1 for Largest Number, 2 for Duplicate Number, 3 for Prime Number");

            string n=Console.ReadLine();
            if (n == "1")
            {
                LargestNo.Entry();
            }
            else if (n == "2")
            {
                DuplicateNo.Entry();
            }
            else if (n == "3")
            {
                Prime.Entry();
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }


        }

    }

}
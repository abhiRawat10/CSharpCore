using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class LargestNo
    {
     public static void Entry()
            {

                Console.WriteLine("Enter the number of elements in the array");
                int n = Convert.ToInt32(Console.ReadLine());

                int[] arr = new int[n];

                Console.WriteLine("Enter the elements of the array");
                for (int i=0; i <n; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(FindLargest(arr));

            }



        static int FindLargest(int[] arr)
        {
            int max = arr[0];
            for (int i=1; i <arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}

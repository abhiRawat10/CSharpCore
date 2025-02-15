using System;
using System.Collections.Generic;
using System.Text;

namespace cSahrpCore
{
    internal class DuplicateNo
    {
        public static void Entry()
        {
            Console.WriteLine("Enter the number of elements in the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];


            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(FindDuplicate(arr,n));

        }

        static int FindDuplicate(int[] arr, int n)
        {
            if (n == 1 || n == 0) return -1;
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            for (int i = 0; i < n; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    return arr[i];
                }
                dict[arr[i]] = true;
            }
            return -1;
        }
    }
}

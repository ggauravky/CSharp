using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_S
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //linear search:
            Console.WriteLine("Linear Search:");
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int num = 5;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == num)
                {
                    Console.WriteLine("Element found at index: " + i);
                    break;
                }
                else
                {
                    Console.WriteLine("Element not found at index: " + i);
                }
            }

            //binary search
            Console.WriteLine("Enter the number to search: ");


            int [] arr2 = { 1,2,3,4,5,6,7,8,9 };
            int num2 = 5;
            int left = 0;
            int right = arr2.Length - 1;
            
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr2[mid] == num2)
                {
                    Console.WriteLine("Element found at index: " + mid);
                    break;
                }
                else if (arr2[mid] < num2)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many numbers you want to store: ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter number for index {i}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nYou entered:");

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }


        }
    }
}

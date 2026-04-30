using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction___Basics_of_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

//Basic Program ✔️
//Variables ✔️
//Data Types ✔️
//Constants ✔️
//Type Casting ✔️
//Overflow Handling ✔️


            Console.WriteLine("Hello, .NET!");

            // Declaring variables of different types
            int number = 10;           // Integer type
            double price = 99.99;     // Decimal number
            char grade = 'A';         // Character
            string name = "Gaurav";   // String
            bool isActive = true;     // Boolean

            // Printing values
            Console.WriteLine("Number: " + number);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Active: " + isActive);

            // Multiple declaration
            int x = 5, y = 6, z = 7;

            // Assign same value
            int a, b, c;
            a = b = c = 10;

            Console.WriteLine(x + y + z);  // 18
            Console.WriteLine(a + b + c);  // 30

            // Declaring constant (value cannot be changed)
            const int MAX = 100;

            Console.WriteLine("Max value is: " + MAX);

            // MAX = 200; ❌ ERROR (cannot change constant)


            int num = 10;

            // Automatic conversion (int → double)
            double result = num;

            Console.WriteLine("Integer: " + num);
            Console.WriteLine("Converted to Double: " + result);

            double num2 = 10.75;

            // Manual conversion (double → int)
            int result2 = (int)num2;

            Console.WriteLine("Original Double: " + num2);
            Console.WriteLine("Converted to Int: " + result2);
            int num3 = int.MaxValue;

            // Without checked (overflow happens silently)
            Console.WriteLine("Without checked: " + (num3 + 1));

            // With checked (throws error)
            try
            {
                checked
                {
                    int result3 = num3 + 1;
                    Console.WriteLine(result3);
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow detected!");
            }
        }
    }
}

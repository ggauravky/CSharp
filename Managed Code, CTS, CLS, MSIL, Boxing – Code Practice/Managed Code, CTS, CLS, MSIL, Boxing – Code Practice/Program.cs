using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managed_Code__CTS__CLS__MSIL__Boxing___Code_Practice
{
    internal class Program
    {
        // CLS-compliant method (simple types)
        public int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            // This code is managed by CLR
            Console.WriteLine("This is Managed Code running under CLR");

            // VALUE TYPE (stored in stack)
            int a = 10;
            int b = a;   // copy created

            b = 20;

            Console.WriteLine("Value Type:");
            Console.WriteLine("a = " + a);  // 10
            Console.WriteLine("b = " + b);  // 20

            // REFERENCE TYPE (stored in heap)
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = arr1;   // reference copied

            arr2[0] = 100;

            Console.WriteLine("\nReference Type:");
            Console.WriteLine("arr1[0] = " + arr1[0]); // 100
            Console.WriteLine("arr2[0] = " + arr2[0]); // 100

            int x = 50;          // Value type

            // Boxing: value type → reference type
            object obj = x;

            Console.WriteLine("Boxed Value: " + obj);

            object obj = 100;   // boxed value

            // Unboxing: reference → value type
            int x = (int)obj;

            Console.WriteLine("Unboxed Value: " + x);

            int num = 10;

            // This is allowed
            double d = num;

            Console.WriteLine(d);

            // ❌ This would cause error (uncomment to test)
            // int x = "Hello";  // Type mismatch not allowed

            Program p = new Program();

            Console.WriteLine(p.Add(5, 3));



        }
    }
}

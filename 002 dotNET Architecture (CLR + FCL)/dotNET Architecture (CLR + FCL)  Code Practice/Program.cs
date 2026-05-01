using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_Architecture__CLR___FCL___Code_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console class (FCL) for output
            Console.WriteLine("Using FCL Example");

            // Math class (FCL)
            int max = Math.Max(10, 20);
            int min = Math.Min(10, 20);
            double power = Math.Pow(2, 3);

            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Power: " + power);

            // Creating a List (dynamic array)
            List<int> numbers = new List<int>();

            // Adding elements
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            // Printing elements
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }


            Stack stack = new Stack();

            // Push elements
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Pop elements (Last In First Out)
            Console.WriteLine(stack.Pop());  // 3
            Console.WriteLine(stack.Pop());  // 2
            Console.WriteLine(stack.Pop());  // 1

            Queue queue = new Queue();

            // Enqueue elements
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            // Dequeue elements (First In First Out)
            Console.WriteLine(queue.Dequeue());  // 10
            Console.WriteLine(queue.Dequeue());  // 20
            Console.WriteLine(queue.Dequeue());  // 30

            string path = "test.txt";

            // Write text to file
            File.WriteAllText(path, "Hello from .NET File Handling");

            // Read text from file
            string content = File.ReadAllText(path);

            Console.WriteLine(content);

            // This code is compiled to MSIL
            // CLR executes it and JIT converts to machine code

            Console.WriteLine("Program is running under CLR");

            int a = 5;
            int b = 10;

            int result = a + b;
            Console.WriteLine(result);
            Console.WriteLine("Result: " + result);

            // Using List from System.Collections.Generic
            List<string> names = new List<string>();

            names.Add("Gaurav");
            names.Add("Raj");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}

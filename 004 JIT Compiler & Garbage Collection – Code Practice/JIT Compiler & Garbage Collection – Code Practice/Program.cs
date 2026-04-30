using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JIT_Compiler___Garbage_Collection___Code_Practice
{
    class Demo
    {
        // Destructor (called when object is destroyed)
        ~Demo()
        {
            Console.WriteLine("Object destroyed by GC");
        }
    }

    internal class Program
    {
        static void Method1()
        {
            Console.WriteLine("Method1 Executed");
        }

        static void Method2()
        {
            Console.WriteLine("Method2 Executed");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started");

            // Calling only Method1
            Method1();

            // Method2 is NOT called → JIT will not compile it now

            // Creating objects
            for (int i = 0; i < 5; i++)
            {
                object obj = new object();
                // Object created in heap
            }

            Console.WriteLine("Objects created");

            // Manually calling Garbage Collector
            GC.Collect();

            Console.WriteLine("Garbage Collection Completed");

            Demo d1 = new Demo();

            // Making object eligible for GC
            d1 = null;

            // Force Garbage Collection
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("End of Main");

            object obj = new object();

            // Check generation of object
            Console.WriteLine("Generation: " + GC.GetGeneration(obj));

            // Force garbage collection
            GC.Collect();

            Console.WriteLine("Garbage Collection Done");

            // Creating many objects
            for (int i = 0; i < 10000; i++)
            {
                object obj = new object();
            }

            Console.WriteLine("Memory used before GC: " + GC.GetTotalMemory(false));

            // Force GC
            GC.Collect();

            Console.WriteLine("Memory after GC: " + GC.GetTotalMemory(true));


        }
    }
}

using System;
using System.Threading; // Required for multithreading

class Program
{
    // Shared variable (used in synchronization demo)
    static int count = 0;

    // Lock object (used to control access)
    static object lockObj = new object();

    // =========================================
    // METHOD 1: Simple Thread Work
    // =========================================
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Child Thread: " + i);
            Thread.Sleep(100); // pause for 100 ms
        }
    }

    // =========================================
    // METHOD 2: Synchronization Example
    // =========================================
    static void Increment()
    {
        for (int i = 0; i < 1000; i++)
        {
            // lock ensures only one thread accesses this block at a time
            lock (lockObj)
            {
                count++;
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("=== SECTION 9: MULTITHREADING ===\n");

        // =========================================
        // 1. MAIN THREAD vs CHILD THREAD
        // =========================================

        Console.WriteLine("=== THREAD CREATION ===");

        Thread t1 = new Thread(PrintNumbers); // create child thread

        t1.Start(); // start child thread

        // Main thread execution
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Main Thread: " + i);
            Thread.Sleep(100);
        }

        // Wait for child thread to finish
        t1.Join();

        Console.WriteLine();

        // =========================================
        // 2. THREAD SYNCHRONIZATION
        // =========================================

        Console.WriteLine("=== SYNCHRONIZATION (LOCK) ===");

        Thread t2 = new Thread(Increment);
        Thread t3 = new Thread(Increment);

        t2.Start();
        t3.Start();

        // Wait for both threads
        t2.Join();
        t3.Join();

        Console.WriteLine("Final Count (Expected 2000): " + count);
        Console.WriteLine();

        // =========================================
        // 3. THREAD METHODS DEMO
        // =========================================

        Console.WriteLine("=== THREAD METHODS ===");

        Thread t4 = new Thread(() =>
        {
            Console.WriteLine("Thread started");
            Thread.Sleep(500); // pause
            Console.WriteLine("Thread finished");
        });

        t4.Start();
        t4.Join();

        Console.WriteLine();

    }
}
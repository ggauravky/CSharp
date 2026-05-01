using System;

// ==============================
// CUSTOM EXCEPTION CLASS
// ==============================
class AgeException : Exception
{
    public AgeException(string message) : base(message) { }
}

// ==============================
// MAIN PROGRAM
// ==============================
class Program
{
    static void Main()
    {
        Console.WriteLine("=== Exception Handling Demo ===\n");

        // ============================
        // 1. TRY-CATCH-FINALLY (Divide by Zero)
        // ============================
        try
        {
            int a = 10;
            int b = 0;

            // This line will cause runtime exception
            int result = a / b;

            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Finally block executed (Cleanup)");
        }


        // ============================
        // 2. MULTIPLE CATCH BLOCKS
        // ============================
        try
        {
            int[] arr = new int[2];

            // This will cause index error
            arr[5] = 10;
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("\nError: Index out of range");
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nGeneral Error: " + ex.Message);
        }


        // ============================
        // 3. THROW KEYWORD
        // ============================
        try
        {
            int age = 15;

            if (age < 18)
            {
                // Manually throw exception
                throw new Exception("Not eligible to vote");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nThrow Example: " + ex.Message);
        }


        // ============================
        // 4. CUSTOM EXCEPTION
        // ============================
        try
        {
            CheckAge(16);
        }
        catch (AgeException ex)
        {
            Console.WriteLine("\nCustom Exception: " + ex.Message);
        }


        // ============================
        // 5. DEBUGGING FRIENDLY CODE
        // ============================
        Console.WriteLine("\n--- Debugging Example ---");

        int x = 5;
        int y = 10;

        // 👉 Put breakpoint here while debugging
        int sum = x + y;

        Console.WriteLine("Sum = " + sum);


        Console.WriteLine("\n=== Program End ===");
    }

    // ==============================
    // METHOD FOR CUSTOM EXCEPTION
    // ==============================
    static void CheckAge(int age)
    {
        if (age < 18)
        {
            // Throw custom exception
            throw new AgeException("Age must be 18 or above");
        }
        else
        {
            Console.WriteLine("Eligible");
        }
    }
}
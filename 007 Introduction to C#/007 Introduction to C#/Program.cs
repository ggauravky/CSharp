using System; // Importing System namespace (for Console, basic operations)

class Program // Class definition (every C# program must have a class)
{
    static void Main() // Entry point of the program
    {
        // ==============================
        // 1. BASIC OUTPUT (Hello World)
        // ==============================

        Console.WriteLine("=== SECTION 1: INTRODUCTION TO C# ===");
        Console.WriteLine("Hello World!");
        Console.WriteLine(); // blank line

        // ==============================
        // 2. VALUE TYPES (CTS Concept)
        // ==============================

        // Value types store actual values in memory (stack)

        int age = 20;             // integer type
        double salary = 25000.5;  // double type
        char grade = 'A';         // character type
        bool isPassed = true;     // boolean type

        Console.WriteLine("=== VALUE TYPES ===");
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Passed: " + isPassed);
        Console.WriteLine();

        // ==============================
        // 3. REFERENCE TYPES (CTS Concept)
        // ==============================

        // Reference types store address (heap memory)

        string name = "Gaurav"; // string is reference type

        Console.WriteLine("=== REFERENCE TYPE ===");
        Console.WriteLine("Name: " + name);
        Console.WriteLine();

        // ==============================
        // 4. TYPE SYSTEM DEMONSTRATION
        // ==============================

        // Showing difference between value and reference type behavior

        int a = 10;
        int b = a; // copy of value
        b = 50;

        Console.WriteLine("=== VALUE TYPE BEHAVIOR ===");
        Console.WriteLine("a: " + a); // remains 10
        Console.WriteLine("b: " + b); // changed to 50
        Console.WriteLine();

        string str1 = "Hello";
        string str2 = str1; // reference copy
        str2 = "World";

        Console.WriteLine("=== REFERENCE TYPE BEHAVIOR ===");
        Console.WriteLine("str1: " + str1);
        Console.WriteLine("str2: " + str2);
        Console.WriteLine();

        // ==============================
        // 5. SIMPLE CALCULATION (CLR EXECUTION DEMO)
        // ==============================

        int x = 5;
        int y = 3;
        int result = x + y; // CLR processes this

        Console.WriteLine("=== SIMPLE CALCULATION ===");
        Console.WriteLine("5 + 3 = " + result);
        Console.WriteLine();

        // ==============================
        // 6. PROGRAM END MESSAGE
        // ==============================

        Console.WriteLine("Program executed successfully using .NET CLR!");
    }
}
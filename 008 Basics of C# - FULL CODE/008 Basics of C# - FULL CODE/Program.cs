using System; // Using System namespace (library)

class Program // Class name (Identifier)
{
    static void Main() // Entry point of program
    {
        Console.WriteLine("=== SECTION 2: BASICS OF C# ===\n");

        // =========================================
        // 1. DATA TYPES (VALUE TYPES)
        // =========================================

        int age = 21;            // integer literal
        float marks = 85.5f;     // float literal (f is required)
        double salary = 25000.75; // double literal
        char grade = 'A';        // character literal
        bool isPassed = true;    // boolean literal

        Console.WriteLine("=== VALUE TYPES ===");
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Marks: " + marks);
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Passed: " + isPassed);
        Console.WriteLine();

        // =========================================
        // 2. REFERENCE TYPE
        // =========================================

        string name = "Gaurav"; // string literal

        Console.WriteLine("=== REFERENCE TYPE ===");
        Console.WriteLine("Name: " + name);
        Console.WriteLine();

        // =========================================
        // 3. VARIABLES & CONSTANTS
        // =========================================

        int x = 10; // variable (can change)
        x = 20;

        const double PI = 3.14159; // constant (cannot change)

        Console.WriteLine("=== VARIABLES & CONSTANTS ===");
        Console.WriteLine("Variable x: " + x);
        Console.WriteLine("Constant PI: " + PI);
        Console.WriteLine();

        // =========================================
        // 4. IDENTIFIERS
        // =========================================

        // Valid identifiers
        int studentAge = 18;
        int _marks = 90;

        Console.WriteLine("=== IDENTIFIERS ===");
        Console.WriteLine("Student Age: " + studentAge);
        Console.WriteLine("Marks: " + _marks);
        Console.WriteLine();

        // =========================================
        // 5. TOKENS (DEMONSTRATION)
        // =========================================

        // Tokens include: keywords, identifiers, literals, operators, punctuators
        int a = 5;   // 'int' = keyword, 'a' = identifier, '5' = literal
        int b = 3;

        int sum = a + b; // '+' is operator

        Console.WriteLine("=== TOKENS DEMO ===");
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine();

        // =========================================
        // 6. LITERALS (ALL TYPES)
        // =========================================

        int intLiteral = 100;
        float floatLiteral = 10.5f;
        char charLiteral = 'Z';
        string stringLiteral = "Hello C#";
        bool boolLiteral = false;

        Console.WriteLine("=== LITERALS ===");
        Console.WriteLine(intLiteral);
        Console.WriteLine(floatLiteral);
        Console.WriteLine(charLiteral);
        Console.WriteLine(stringLiteral);
        Console.WriteLine(boolLiteral);
        Console.WriteLine();

        // =========================================
        // 7. KEYWORDS (USAGE EXAMPLE)
        // =========================================

        // Keywords used: int, float, string, bool, class, static, void

        Console.WriteLine("=== KEYWORDS ===");
        Console.WriteLine("Keywords are reserved words like int, float, class, etc.");
        Console.WriteLine();

        // =========================================
        // END
        // =========================================

        Console.WriteLine("Section 2 program executed successfully!");
    }
}
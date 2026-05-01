using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SECTION 3: TYPE CONVERSION & OPERATORS ===\n");

        // =========================================
        // 1. IMPLICIT TYPE CONVERSION (Automatic)
        // =========================================

        int intValue = 10;
        double doubleValue = intValue; // int → double (automatic)

        Console.WriteLine("=== IMPLICIT CONVERSION ===");
        Console.WriteLine("Int Value: " + intValue);
        Console.WriteLine("Converted to Double: " + doubleValue);
        Console.WriteLine();

        // =========================================
        // 2. EXPLICIT TYPE CONVERSION (Casting)
        // =========================================

        double num = 10.75;
        int result = (int)num; // manual casting

        Console.WriteLine("=== EXPLICIT CONVERSION ===");
        Console.WriteLine("Original Double: " + num);
        Console.WriteLine("Converted to Int: " + result); // decimal lost
        Console.WriteLine();

        // =========================================
        // 3. BOXING (Value → Object)
        // =========================================

        int value = 100;
        object obj = value; // boxing

        Console.WriteLine("=== BOXING ===");
        Console.WriteLine("Value: " + value);
        Console.WriteLine("Object: " + obj);
        Console.WriteLine();

        // =========================================
        // 4. UNBOXING (Object → Value)
        // =========================================

        object obj2 = 200;
        int value2 = (int)obj2; // unboxing

        Console.WriteLine("=== UNBOXING ===");
        Console.WriteLine("Object: " + obj2);
        Console.WriteLine("Value: " + value2);
        Console.WriteLine();

        // =========================================
        // 5. ARITHMETIC OPERATORS
        // =========================================

        int a = 10, b = 3;

        Console.WriteLine("=== ARITHMETIC OPERATORS ===");
        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b)); // integer division
        Console.WriteLine("Modulus: " + (a % b));
        Console.WriteLine();

        // =========================================
        // 6. RELATIONAL OPERATORS
        // =========================================

        Console.WriteLine("=== RELATIONAL OPERATORS ===");
        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < b: " + (a < b));
        Console.WriteLine("a == b: " + (a == b));
        Console.WriteLine("a != b: " + (a != b));
        Console.WriteLine();

        // =========================================
        // 7. LOGICAL OPERATORS
        // =========================================

        bool x = true, y = false;

        Console.WriteLine("=== LOGICAL OPERATORS ===");
        Console.WriteLine("x && y: " + (x && y)); // AND
        Console.WriteLine("x || y: " + (x || y)); // OR
        Console.WriteLine("!x: " + (!x));         // NOT
        Console.WriteLine();

        // =========================================
        // 8. ASSIGNMENT OPERATORS
        // =========================================

        int num1 = 10;

        Console.WriteLine("=== ASSIGNMENT OPERATORS ===");
        num1 += 5; // num1 = num1 + 5
        Console.WriteLine("After += 5: " + num1);

        num1 -= 3; // num1 = num1 - 3
        Console.WriteLine("After -= 3: " + num1);
        Console.WriteLine();

        // =========================================
        // 9. BITWISE OPERATORS
        // =========================================

        int p = 5;  // 101
        int q = 3;  // 011

        Console.WriteLine("=== BITWISE OPERATORS ===");
        Console.WriteLine("p & q: " + (p & q)); // AND
        Console.WriteLine("p | q: " + (p | q)); // OR
        Console.WriteLine("p ^ q: " + (p ^ q)); // XOR
        Console.WriteLine();

        // =========================================
        // 10. TERNARY (CONDITIONAL) OPERATOR
        // =========================================

        int age = 18;
        string status = (age >= 18) ? "Adult" : "Minor";

        Console.WriteLine("=== TERNARY OPERATOR ===");
        Console.WriteLine("Status: " + status);
        Console.WriteLine();

    }
}
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SECTION 5: CONTROL STATEMENTS & LOOPS ===\n");

        // =========================================
        // 1. IF STATEMENT
        // =========================================

        int age = 20;

        Console.WriteLine("=== IF STATEMENT ===");
        if (age >= 18)
        {
            Console.WriteLine("Eligible to vote");
        }
        Console.WriteLine();

        // =========================================
        // 2. IF-ELSE STATEMENT
        // =========================================

        int number = 5;

        Console.WriteLine("=== IF-ELSE STATEMENT ===");
        if (number % 2 == 0)
        {
            Console.WriteLine("Even Number");
        }
        else
        {
            Console.WriteLine("Odd Number");
        }
        Console.WriteLine();

        // =========================================
        // 3. NESTED IF
        // =========================================

        bool hasID = true;

        Console.WriteLine("=== NESTED IF ===");
        if (age >= 18)
        {
            if (hasID)
            {
                Console.WriteLine("Allowed Entry");
            }
        }
        Console.WriteLine();

        // =========================================
        // 4. SWITCH STATEMENT
        // =========================================

        int day = 2;

        Console.WriteLine("=== SWITCH STATEMENT ===");
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;

            case 2:
                Console.WriteLine("Tuesday");
                break;

            default:
                Console.WriteLine("Invalid Day");
                break;
        }
        Console.WriteLine();

        // =========================================
        // 5. FOR LOOP
        // =========================================

        Console.WriteLine("=== FOR LOOP ===");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        // =========================================
        // 6. WHILE LOOP
        // =========================================

        Console.WriteLine("=== WHILE LOOP ===");
        int i2 = 1;

        while (i2 <= 3)
        {
            Console.WriteLine(i2);
            i2++;
        }
        Console.WriteLine();

        // =========================================
        // 7. DO-WHILE LOOP
        // =========================================

        Console.WriteLine("=== DO-WHILE LOOP ===");
        int i3 = 5;

        do
        {
            Console.WriteLine(i3);
            i3++;
        }
        while (i3 <= 3); // runs at least once
        Console.WriteLine();

        // =========================================
        // 8. FOREACH LOOP
        // =========================================

        Console.WriteLine("=== FOREACH LOOP ===");
        int[] arr = { 10, 20, 30 };

        foreach (int item in arr)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // =========================================
        // 9. BREAK & CONTINUE
        // =========================================

        Console.WriteLine("=== BREAK & CONTINUE ===");

        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
                continue; // skip 3

            if (i == 5)
                break; // stop loop

            Console.WriteLine(i);
        }

        Console.WriteLine();
    }
}
using System;
using System.Collections; // For ArrayList
using System.Text;        // For StringBuilder

class Program
{
    // =========================================
    // ENUM DECLARATION (Named Constants)
    // =========================================
    enum Days
    {
        Monday,    // 0
        Tuesday,   // 1
        Wednesday  // 2
    }

    static void Main()
    {
        Console.WriteLine("=== SECTION 4: DATA STRUCTURES ===\n");

        // =========================================
        // 1. ENUM
        // =========================================

        Days today = Days.Tuesday;

        Console.WriteLine("=== ENUM ===");
        Console.WriteLine("Today: " + today);
        Console.WriteLine("Numeric Value: " + (int)today); // convert enum to int
        Console.WriteLine();

        // =========================================
        // 2. SINGLE DIMENSION ARRAY
        // =========================================

        int[] arr = { 10, 20, 30, 40 };

        Console.WriteLine("=== SINGLE DIMENSION ARRAY ===");
        Console.WriteLine("First Element: " + arr[0]);
        Console.WriteLine("Third Element: " + arr[2]);

        Console.WriteLine("All Elements:");
        foreach (int item in arr)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // =========================================
        // 3. MULTIDIMENSION ARRAY
        // =========================================

        int[,] matrix =
        {
            {1, 2},
            {3, 4}
        };

        Console.WriteLine("=== MULTIDIMENSION ARRAY ===");
        Console.WriteLine("Element [0,1]: " + matrix[0, 1]);

        Console.WriteLine("All Elements:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // =========================================
        // 4. JAGGED ARRAY (ARRAY OF ARRAYS)
        // =========================================

        int[][] jagged = new int[2][];

        jagged[0] = new int[] { 1, 2 };
        jagged[1] = new int[] { 3, 4, 5 };

        Console.WriteLine("=== JAGGED ARRAY ===");
        Console.WriteLine("Element [1][2]: " + jagged[1][2]);

        Console.WriteLine("All Elements:");
        for (int i = 0; i < jagged.Length; i++)
        {
            foreach (int val in jagged[i])
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // =========================================
        // 5. ARRAYLIST (DYNAMIC ARRAY)
        // =========================================

        ArrayList list = new ArrayList();

        list.Add(10);        // int
        list.Add("Hello");   // string
        list.Add(5.5);       // double

        Console.WriteLine("=== ARRAYLIST ===");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // =========================================
        // 6. STRING METHODS
        // =========================================

        string text = "Hello World";

        Console.WriteLine("=== STRING METHODS ===");
        Console.WriteLine("Length: " + text.Length);
        Console.WriteLine("Upper: " + text.ToUpper());
        Console.WriteLine("Lower: " + text.ToLower());
        Console.WriteLine("Contains 'Hello': " + text.Contains("Hello"));
        Console.WriteLine("Substring (0,5): " + text.Substring(0, 5));
        Console.WriteLine();

        // =========================================
        // 7. STRINGBUILDER (MUTABLE STRING)
        // =========================================

        StringBuilder sb = new StringBuilder("Hello");

        sb.Append(" Gaurav"); // adding text

        Console.WriteLine("=== STRINGBUILDER ===");
        Console.WriteLine(sb);
        Console.WriteLine();

    }
}
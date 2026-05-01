using System;
using System.IO; // Required for file handling

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SECTION 6: INPUT/OUTPUT & STREAMS ===\n");

        // =========================================
        // 1. BASIC OUTPUT
        // =========================================

        Console.WriteLine("=== OUTPUT METHODS ===");
        Console.Write("Hello ");
        Console.WriteLine("Gaurav"); // new line
        Console.WriteLine();

        // =========================================
        // 2. INPUT FROM USER
        // =========================================

        Console.WriteLine("=== INPUT FROM USER ===");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine(); // input always string

        Console.WriteLine("Hello " + name);
        Console.WriteLine();

        // =========================================
        // 3. TYPE CONVERSION FROM INPUT
        // =========================================

        Console.WriteLine("=== TYPE CONVERSION ===");
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine()); // string → int

        Console.WriteLine("You entered: " + num);
        Console.WriteLine();

        // =========================================
        // 4. OUTPUT FORMATTING
        // =========================================

        int age = 21;

        Console.WriteLine("=== OUTPUT FORMATTING ===");

        // Concatenation
        Console.WriteLine("Age: " + age);

        // Placeholder
        Console.WriteLine("Age (placeholder): {0}", age);

        // String Interpolation
        Console.WriteLine($"Age (interpolation): {age}");

        Console.WriteLine();

        // =========================================
        // 5. FILESTREAM (LOW LEVEL FILE WRITE)
        // =========================================

        Console.WriteLine("=== FILESTREAM ===");

        FileStream fs = new FileStream("file1.txt", FileMode.Create);

        byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello FileStream");

        fs.Write(data, 0, data.Length); // writing data
        fs.Close();

        Console.WriteLine("FileStream: file1.txt created");
        Console.WriteLine();

        // =========================================
        // 6. STREAMWRITER (WRITE FILE)
        // =========================================

        Console.WriteLine("=== STREAMWRITER ===");

        StreamWriter sw = new StreamWriter("file2.txt");

        sw.WriteLine("Hello from StreamWriter");
        sw.WriteLine("Second line");

        sw.Close();

        Console.WriteLine("StreamWriter: file2.txt written");
        Console.WriteLine();

        // =========================================
        // 7. STREAMREADER (READ FILE)
        // =========================================

        Console.WriteLine("=== STREAMREADER ===");

        StreamReader sr = new StreamReader("file2.txt");

        string content = sr.ReadToEnd(); // read entire file
        sr.Close();

        Console.WriteLine("Content of file2.txt:");
        Console.WriteLine(content);

        Console.WriteLine();

        // =========================================
        // END
        // =========================================

        Console.WriteLine("Section 6 program executed successfully!");
    }
}
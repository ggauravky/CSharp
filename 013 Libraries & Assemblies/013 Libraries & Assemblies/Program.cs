using System;              // System library (basic input/output)
using System.IO;           // IO library (file handling)
using System.Collections;  // Collections library (ArrayList)

namespace MyApplication // Namespace (group of related classes)
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== SECTION 7: LIBRARIES & ASSEMBLIES ===\n");

            // =========================================
            // 1. LIBRARIES (FCL - Framework Class Library)
            // =========================================

            // Using System library → Console
            Console.WriteLine("Using System Library");

            // Using System.Collections → ArrayList
            ArrayList list = new ArrayList();
            list.Add("Library Example");

            Console.WriteLine("Using Collections Library:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Using System.IO → File Handling
            Console.WriteLine("Using IO Library:");
            File.WriteAllText("lib_demo.txt", "Hello from Library");

            string data = File.ReadAllText("lib_demo.txt");
            Console.WriteLine("File Content: " + data);
            Console.WriteLine();

            // =========================================
            // 2. ASSEMBLY (THEORY IN COMMENTS)
            // =========================================

            /*
             Assembly = compiled output (.exe or .dll)

             When you compile this program:
             → It becomes an assembly file (.exe)

             Assembly contains:
             ✔ IL Code (Intermediate Language)
             ✔ Metadata (info about classes, methods)
             ✔ Manifest (version, name, etc.)
            */

            Console.WriteLine("Assembly concept demonstrated (see comments)");
            Console.WriteLine();

            // =========================================
            // 3. TYPES OF ASSEMBLIES (THEORY)
            // =========================================

            /*
             1. Private Assembly:
                - Used by single application
                - Stored in project folder

             2. Shared Assembly:
                - Used by multiple applications
                - Stored in GAC
            */

            Console.WriteLine("Types of Assemblies explained in comments");
            Console.WriteLine();

            // =========================================
            // 4. METADATA (THEORY)
            // =========================================

            /*
             Metadata = data about data

             Contains:
             ✔ Class names
             ✔ Methods
             ✔ Properties
             ✔ References

             CLR uses metadata to execute program
            */

            Console.WriteLine("Metadata concept explained in comments");
            Console.WriteLine();

            // =========================================
            // 5. NAMESPACE DEMO
            // =========================================

            Console.WriteLine("Current Namespace: MyApplication");
            Console.WriteLine("Namespace groups related classes together");
            Console.WriteLine();

        }
    }
}
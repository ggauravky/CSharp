using System;
using System.Reflection; // For assembly info

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SECTION 8: .NET ASSEMBLIES (ADVANCED) ===\n");

        // =========================================
        // 1. CURRENT ASSEMBLY INFORMATION
        // =========================================

        // Getting current assembly details
        Assembly asm = Assembly.GetExecutingAssembly();

        Console.WriteLine("=== CURRENT ASSEMBLY INFO ===");
        Console.WriteLine("Assembly Name: " + asm.GetName().Name);
        Console.WriteLine("Version: " + asm.GetName().Version);
        Console.WriteLine();

        // =========================================
        // 2. GLOBAL ASSEMBLY CACHE (GAC)
        // =========================================

        /*
         GAC = Global Assembly Cache

         ✔ Central storage for shared assemblies
         ✔ Used by multiple applications
         ✔ Avoids duplication

         Example:
         Instead of storing same DLL in 10 apps,
         store once in GAC → all apps use it
        */

        Console.WriteLine("=== GAC ===");
        Console.WriteLine("GAC stores shared assemblies centrally");
        Console.WriteLine();

        // =========================================
        // 3. STRONG NAME
        // =========================================

        /*
         Strong Name = Unique identity of assembly

         Includes:
         ✔ Name
         ✔ Version
         ✔ Culture
         ✔ Public Key

         Important:
         Only strong-named assemblies can be stored in GAC
        */

        Console.WriteLine("=== STRONG NAME ===");
        Console.WriteLine("Strong Name provides unique identity to assembly");
        Console.WriteLine();

        // =========================================
        // 4. VERSIONING
        // =========================================

        /*
         Version Format:
         Major.Minor.Build.Revision

         Example:
         1.0.0.0

         Purpose:
         ✔ Manage multiple versions
         ✔ Avoid conflicts
        */

        Console.WriteLine("=== VERSIONING ===");
        Console.WriteLine("Version format: Major.Minor.Build.Revision");
        Console.WriteLine("Example: 1.0.0.0");
        Console.WriteLine();

        // =========================================
        // 5. DEPLOYMENT
        // =========================================

        /*
         Deployment = distributing application

         Types:

         1. Private Deployment:
            - Assembly in app folder
            - Used by single app

         2. Shared Deployment:
            - Assembly in GAC
            - Used by multiple apps
            - Requires strong name
        */

        Console.WriteLine("=== DEPLOYMENT ===");
        Console.WriteLine("Private → Single App");
        Console.WriteLine("Shared → Multiple Apps (GAC)");
        Console.WriteLine();

        // =========================================
        // 6. SUMMARY
        // =========================================

        Console.WriteLine("=== SUMMARY ===");
        Console.WriteLine("GAC → Shared storage");
        Console.WriteLine("Strong Name → Unique identity");
        Console.WriteLine("Versioning → Manage versions");
        Console.WriteLine("Deployment → Distribution");
        Console.WriteLine();

    }
}
using System;
using System.Web.Services;

// ==============================
// WEB SERVICE CLASS
// ==============================

// Define Web Service
[WebService(Namespace = "http://example.com/myservice")]
public class MyService : WebService
{
    // Web Method 1 (Addition)
    [WebMethod]
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Web Method 2 (Greeting)
    [WebMethod]
    public string Greet(string name)
    {
        return "Hello, " + name + "!";
    }
}

// ==============================
// CLIENT PROGRAM (SIMULATION)
// ==============================

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Web Service Demo ===\n");

        // Create service object (simulating client call)
        MyService service = new MyService();

        // ============================
        // CALL METHOD 1 (Add)
        // ============================
        int result = service.Add(5, 3);
        Console.WriteLine("Addition Result: " + result);

        // ============================
        // CALL METHOD 2 (Greet)
        // ============================
        string message = service.Greet("Gaurav");
        Console.WriteLine("Greeting: " + message);

        // ============================
        // IMPORTANT CONCEPTS (EXAM)
        // ============================

        Console.WriteLine("\n--- Important Concepts ---");

        Console.WriteLine("WSDL: Describes web service methods and structure");
        Console.WriteLine("UDDI: Directory to find web services");
        Console.WriteLine("DISCO: Used to discover services on server");

    }
}
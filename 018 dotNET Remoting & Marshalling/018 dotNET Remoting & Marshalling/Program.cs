using System;

// ==============================
// MARSHAL BY VALUE CLASS
// ==============================

// Serializable → used for Marshal by Value
[Serializable]
public class DataByValue
{
    public int value = 10;

    public void Show()
    {
        Console.WriteLine("Value (By Value) = " + value);
    }
}

// ==============================
// MARSHAL BY REFERENCE CLASS
// ==============================

// MarshalByRefObject → used for remote reference
public class RemoteObject : MarshalByRefObject
{
    // Method 1 → Greeting (SAO concept)
    public string GetMessage()
    {
        return "Hello from Server (SAO Concept)";
    }

    // Method 2 → Addition (CAO concept)
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Method 3 → Modify value (Reference concept)
    public void ModifyValue(DataByValue obj)
    {
        obj.value = 999;  // This change won't reflect if passed by value
    }
}

// ==============================
// MAIN PROGRAM (CLIENT SIDE)
// ==============================

class Program
{
    static void Main()
    {
        Console.WriteLine("=== .NET REMOTING & MARSHALLING DEMO ===\n");

        // =========================================
        // 1. SERVER ACTIVATED OBJECT (SAO Simulation)
        // =========================================

        Console.WriteLine("---- SAO (Server Activated Object) ----");

        // Server creates object
        RemoteObject serverObject = new RemoteObject();

        // Client calls method
        string message = serverObject.GetMessage();

        Console.WriteLine("Server Response: " + message);


        // =========================================
        // 2. CLIENT ACTIVATED OBJECT (CAO Simulation)
        // =========================================

        Console.WriteLine("\n---- CAO (Client Activated Object) ----");

        // Client creates object
        RemoteObject clientObject = new RemoteObject();

        int sum = clientObject.Add(5, 3);

        Console.WriteLine("Addition Result: " + sum);


        // =========================================
        // 3. MARSHAL BY VALUE
        // =========================================

        Console.WriteLine("\n---- Marshal By Value ----");

        DataByValue data = new DataByValue();

        Console.WriteLine("Before sending:");
        data.Show();

        // Simulate sending copy
        RemoteObject obj = new RemoteObject();
        obj.ModifyValue(data);

        Console.WriteLine("After modification attempt:");
        data.Show();

        // NOTE: In real remoting → copy is sent, original not changed


        // =========================================
        // 4. MARSHAL BY REFERENCE
        // =========================================

        Console.WriteLine("\n---- Marshal By Reference ----");

        RemoteObject refObj = new RemoteObject();

        int result = refObj.Add(10, 20);

        Console.WriteLine("Multiply/Add via Reference: " + result);


        Console.WriteLine("\n=== Program Finished ===");
    }
}
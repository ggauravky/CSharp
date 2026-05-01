using System;
using System.Globalization;
using System.Reflection;
using System.Xml;

// ==============================
// USER CLASS (for Auth Demo)
// ==============================
class User
{
    public string Username;
    public string Role;

    public User(string username, string role)
    {
        Username = username;
        Role = role;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Advanced .NET Concepts Demo ===\n");

        // =========================================
        // 1. DISTRIBUTED APPLICATION (SIMULATION)
        // =========================================
        Console.WriteLine("---- Distributed Application ----");

        // Simulating client calling server method
        int result = ServerAdd(5, 10);
        Console.WriteLine("Result from Server: " + result);


        // =========================================
        // 2. REFLECTION
        // =========================================
        Console.WriteLine("\n---- Reflection ----");

        Type t = typeof(string);

        Console.WriteLine("Methods of String class:");

        foreach (MethodInfo m in t.GetMethods())
        {
            Console.WriteLine(m.Name);
        }


        // =========================================
        // 3. GLOBALIZATION & LOCALIZATION
        // =========================================
        Console.WriteLine("\n---- Globalization ----");

        CultureInfo culture = new CultureInfo("hi-IN");

        Console.WriteLine("Date (India): " + DateTime.Now.ToString(culture));
        Console.WriteLine("Currency (India): " + (1000).ToString("C", culture));


        // =========================================
        // 4. AUTHENTICATION & AUTHORIZATION
        // =========================================
        Console.WriteLine("\n---- Authentication & Authorization ----");

        User user = new User("Gaurav", "Admin");

        // Authentication
        if (user.Username == "Gaurav")
        {
            Console.WriteLine("User Authenticated");

            // Authorization
            if (user.Role == "Admin")
            {
                Console.WriteLine("Access Granted (Admin)");
            }
            else
            {
                Console.WriteLine("Access Denied");
            }
        }


        // =========================================
        // 5. XML WRITE
        // =========================================
        Console.WriteLine("\n---- XML Write ----");

        XmlDocument doc = new XmlDocument();

        // Create root element
        XmlElement root = doc.CreateElement("student");

        // Create child elements
        XmlElement name = doc.CreateElement("name");
        name.InnerText = "Gaurav";

        XmlElement age = doc.CreateElement("age");
        age.InnerText = "20";

        // Append elements
        root.AppendChild(name);
        root.AppendChild(age);

        doc.AppendChild(root);

        // Save file
        doc.Save("student.xml");

        Console.WriteLine("XML File Created");


        // =========================================
        // 6. XML READ
        // =========================================
        Console.WriteLine("\n---- XML Read ----");

        XmlDocument readDoc = new XmlDocument();
        readDoc.Load("student.xml");

        XmlNode node = readDoc.SelectSingleNode("//name");

        Console.WriteLine("Student Name: " + node.InnerText);


        Console.WriteLine("\n=== Program End ===");
    }

    // Simulated Server Method
    static int ServerAdd(int a, int b)
    {
        return a + b;
    }
}
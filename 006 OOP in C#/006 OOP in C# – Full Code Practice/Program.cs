using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    // Data members
    public int id;
    public string name;

    // Method
    public void Display()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Name: " + name);
    }
}
class Person
{
    private int id;
    private string name;

    // Property
    public int ID
    {
        get { return id; }       // Read
        set { id = value; }      // Write
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

class Demo
{
    private string[] data = new string[3];

    // Indexer
    public string this[int index]
    {
        get { return data[index]; }
        set { data[index] = value; }
    }
}

// Base class
class Animal
{
    public void Sound()
    {
        Console.WriteLine("Animal makes sound");
    }
}

// Derived class
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks");
    }
}


class Person
{
    private int id;
    private string name;

    // Property
    public int ID
    {
        get { return id; }       // Read
        set { id = value; }      // Write
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

class Demo2
{
    private string[] data = new string[3];

    // Indexer
    public string this[int index]
    {
        get { return data[index]; }
        set { data[index] = value; }
    }
}

class Demo3
{
    int x;

    public Demo3(int x)
    {
        this.x = x;
    }

    // Overloading + operator
    public static Demo3 operator +(Demo3 a, Demo3 b)
    {
        return new Demo3(a.x + b.x);
    }

    public void Display()
    {
        Console.WriteLine(x);
    }
}



namespace _006_OOP_in_C____Full_Code_Practice
{
    internal class Program
    {

        public delegate void Notify();

        public static event Notify myEvent;

        static void Message()
        {
            Console.WriteLine("Event Triggered");
        }


        // Delegate declaration
        public delegate void MyDelegate();

        static void Show()
        {
            Console.WriteLine("Hello Delegate");
        }

        static void Main(string[] args)
        {
            // Creating object
            Student s1 = new Student();

            // Assign values
            s1.id = 1;
            s1.name = "Gaurav";

            // Call method
            s1.Display();

            Person p = new Person();

            p.ID = 10;
            p.Name = "Raj";

            Console.WriteLine(p.ID);
            Console.WriteLine(p.Name);


            Demo d = new Demo();

            d[0] = "A";
            d[1] = "B";
            d[2] = "C";

            Console.WriteLine(d[0]);
            Console.WriteLine(d[1]);


            Dog d = new Dog();

            d.Sound();  // from base class
            d.Bark();   // own method

            Person p = new Person();

            p.ID = 10;
            p.Name = "Raj";

            Console.WriteLine(p.ID);
            Console.WriteLine(p.Name);


            Demo2 d = new Demo2();
            d[0] = "A";
            d[1] = "B";
            d[2] = "C";

            Console.WriteLine(d[0]);
            Console.WriteLine(d[1]);


            Demo3 d1 = new Demo3(5);
            Demo3 d2 = new Demo3(10);

            Demo3 d3 = d1 + d2;
            d3.Display();

            MyDelegate d = Show; // Assign method
            d();                 // Call method

            myEvent += Message; // Attach method
            myEvent();          // Trigger event
        }
    }
}

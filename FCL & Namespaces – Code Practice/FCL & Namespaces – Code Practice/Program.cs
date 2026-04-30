using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCL___Namespaces___Code_Practice
{
    class Test
    {
        public void Show()
        {
            Console.WriteLine("Inside MyApp Namespace");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            // Using Console class from System namespace
            Console.WriteLine("Hello from System Namespace");

            int a = 10, b = 20;

            // Using Math class from FCL
            Console.WriteLine("Maximum: " + Math.Max(a, b));
            Console.WriteLine("Minimum: " + Math.Min(a, b));
            Console.WriteLine("Square Root of 25: " + Math.Sqrt(25));


            // Current date and time
            DateTime now = DateTime.Now;

            Console.WriteLine("Current Date & Time: " + now);
            Console.WriteLine("Today's Date: " + now.Date);
            Console.WriteLine("Current Time: " + now.TimeOfDay);


            // Using List from Collections namespace
            List<string> names = new List<string>();

            names.Add("Gaurav");
            names.Add("Raj");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Accessing class using namespace
            MyApp.Test obj = new MyApp.Test();
            obj.Show();

            // Using alias instead of full namespace
            Col.List<int> numbers = new Col.List<int>();

            numbers.Add(1);
            numbers.Add(2);

            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            // Using full namespace without 'using'
            System.Console.WriteLine("Using Fully Qualified Name");


        }
    }
}

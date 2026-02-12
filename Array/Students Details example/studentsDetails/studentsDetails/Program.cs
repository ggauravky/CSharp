using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String stdname1, stdname2, stdname3;
            String classname1, classname2, classname3;
            String rollno1, rollno2, rollno3;

            String getresult;
            ArrayList arrayList = new ArrayList();
            Console.WriteLine("initial capacity : " + arrayList.Capacity);
            Console.WriteLine("element initially : " + arrayList.Count);
            Console.WriteLine("details of students 1: ");
            classname1 = Console.ReadLine();
            Console.WriteLine("roll no of student 1: ");
            rollno1 = Console.ReadLine();
            Console.WriteLine("entre details of student 2: ");
            Console.WriteLine("class name of student 2: ");
            classname2 = Console.ReadLine();
            Console.WriteLine("roll no of student 2: ");
            rollno2 = Console.ReadLine();
            Console.WriteLine("entre details of student 3: ");
            Console.WriteLine("class name of student 3: ");
            classname3 = Console.ReadLine();
            Console.WriteLine("roll no of student 3: ");
            rollno3 = Console.ReadLine();

            arrayList.Add(classname1);
            arrayList.Add(rollno1);
            arrayList.Add(classname2);
            arrayList.Add(rollno2);
            arrayList.Add(classname3);
            arrayList.Add(rollno3);

            Console.WriteLine("Current capacity : " + arrayList.Capacity);
            Console.WriteLine("count"+ arrayList.Count);

            for(int i = 0; i < arrayList.Capacity; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            Console.WriteLine();
            Console.WriteLine("to remove the details of student 2: press Y or to interchange student details with student 3 press N");

            getresult = Console.ReadLine();
            if (getresult == "Y")
            {
                Console.WriteLine("remaning 2nd student details are: ");
                arrayList.Remove(classname2);
                arrayList.Remove(rollno2);
                Console.WriteLine("Current capacity : " + arrayList.Capacity);
                Console.WriteLine("count" + arrayList.Count);
                for (int i = 0; i <arrayList.Count; i++)
                {
                    Console.WriteLine(arrayList[i] + "");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Changing elements:");
                arrayList[0]= classname3;
                arrayList[1] = classname3;
                arrayList[2] = rollno3;
                arrayList[6] = classname1;
                arrayList[7] = classname2;
                arrayList[8] = rollno1;
                Console.WriteLine("printing");
                for (int i = 0; i <arrayList.Count; i++)
                {
                    Console.WriteLine(arrayList[i] + "");
                }
            }

                
        }
    }
}

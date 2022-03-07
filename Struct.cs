using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Struct
    {
        struct Student
        {

            public Student(string name, int roll)
            {
                Name = name;
                Roll = roll;
            }

            public string Name
            {
                get;
                set;
            }
            public int Roll
            {
                get;
                set;
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student("Jack", 67);
            Console.WriteLine(s.Name + " " + s.Roll);
            s.Name = "John";
            s.Roll = 76;
            Console.WriteLine(s.Name + " " + s.Roll);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public string name;
        public int roll;

        // Default Constructor
        public Student()
        {
            name = "Default";
            roll = 0;
        }

        // 1 Argument Constructor
        public Student(string name)
        {
            this.name = name;
            this.roll = 0;
        }

        // Overloading Constructor
        public Student(string name, int roll)
        {
            this.name = name;
            this.roll = roll;
        }

        // Copy Constructor
        public Student(Student student)
        {
            this.name = student.name;
            this.roll = student.roll;
        }

        // Static Constructor
        static Student()
        {
            Console.WriteLine("Static constructor is called");
        }

        public void print()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Roll: " + this.roll);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Press to start");
            Console.ReadKey();
            // Default
            Student o1 = new Student();
            o1.print();

            Console.ReadKey();

            // 1 argument
            o1 = new Student("John");
            o1.print();

            Console.ReadKey();

            // Overloaded
            Student jack = new Student("Jack", 10);
            jack.print();

            Console.ReadKey();

            // Copy
            Student jack2 = new Student(jack);
            jack2.print();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Properties
    {
        class Student
        {
            private string name;
            private int marks;
            
            public Student(string name, int marks)
            {
                this.name = name;
                this.marks = marks;
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Marks
            {
                get { return marks; }
            }

            public void print()
            {
                Console.WriteLine("Name:" + this.name);
                Console.WriteLine("Marks:" + this.marks);
            }
        }
        static void Main(string[] args)
        {
            Student s1 = new Student("John", 85);

            Console.ReadKey();

            s1.print();

            Console.ReadKey();

            s1.Name = "Jack";
            s1.print();

            Console.ReadKey();
            Console.WriteLine(s1.Marks);

            Console.ReadKey();
        }
    }
}

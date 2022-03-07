using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Interface
    {
        interface IPrint
        {
            void Print();
        }

        class A : IPrint
        {
            public void Print()
            {
                Console.WriteLine("From A, IPrint");
            }
        }

        interface IPrint2
        {
            void Print2();
        }

        class B : IPrint, IPrint2
        {
            public void Print()
            {
                Console.WriteLine("From B, IPrint");
            }

            public void Print2()
            {
                Console.WriteLine("From B, IPrint2");
            }
        }
        static void Main(string[] args)
        {
            A obj1 = new A();
            B obj2 = new B();
            obj1.Print();
            obj2.Print();
            obj2.Print2();

            Console.ReadKey();
        }
    }
}

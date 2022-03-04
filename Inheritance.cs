using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Inheritance
    {
        class A
        {
            public int a = 1;
        }

        class B : A
        {
            public int b = 2;
            public int a = 5;
        }

        class C : B
        {
            public int c = 3;
            public int a = 4;

            public void m()
            {
                Console.WriteLine(base.a);
            }
        }

        static void Main(string[] args)
        {
            C obj = new C();
            //Console.WriteLine(obj.m());
            obj.m();

            Console.ReadKey();
        }
    }
}

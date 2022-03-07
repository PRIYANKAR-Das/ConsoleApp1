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
            protected int b = 2;
        }

        class C : B
        {
            private int c = 3;

            public void m()
            {
                Console.WriteLine(a +  " " + b + " " + c);
            }
        }

        class D
        {
            internal int d = 4;
        }

        class E : D
        {
            private protected int e = 5;
        }

        class F : E
        {
            public void m()
            {
                Console.WriteLine(e);
            }
        }
        static void Main(string[] args)
        {
            C obj = new C();
            //Console.WriteLine(obj.m());
            obj.m();

            E obj2 = new E();
            Console.WriteLine(obj2.d);

            D obj3 = new D();
            Console.WriteLine(obj3.d);

            F obj4 = new F();
            obj4.m();

            Console.ReadKey();
        }
    }
}

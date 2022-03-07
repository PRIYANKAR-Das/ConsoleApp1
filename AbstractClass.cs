using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AbstractClass
    {
        public abstract class A
        {
            public abstract void p();
        }

        public class B : A
        {
            public override void p()
            {
                Console.WriteLine("From B");
            }
        }

        public class C : A
        {
            public override void p()
            {
                Console.WriteLine("From C");
            }
        }
        static void Main(string[] args)
        {
            A o1 = new B();
            A o2 = new C();

            o1.p();
            o2.p();

            Console.ReadKey();
        }
    }
}

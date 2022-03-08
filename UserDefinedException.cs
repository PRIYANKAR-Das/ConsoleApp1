using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UserDefinedException
    {
        class NonZeroException : Exception
        {
            public NonZeroException(string message)
                : base(message)
            {

            }
        }
        class A
        {
            public int a;

            public void m()
            {
                if (a > 0)
                {
                    throw (new NonZeroException("Non zero"));
                }
            }
        }
        static void Main(string[] args)
        {
            A obj1 = new A();

            obj1.a = 1;

            try
            {
                obj1.m();
            }
            catch (NonZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }

            Console.ReadKey();
        }
    }
}

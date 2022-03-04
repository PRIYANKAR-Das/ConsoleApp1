using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Generic
    {
        class GenericEquals<T>
        {
            T first;
            T second;

            public GenericEquals(T first, T second)
            {
                this.first = first;
                this.second = second;
            }

            public void equals()
            {
                Console.WriteLine("first == second: {0}", first.Equals(second));
            }
        }

        static void Main(string[] args)
        {
            GenericEquals<double> obj = new GenericEquals<double>(1.01, 1);
            obj.equals();
            Console.ReadKey();
        }
    }
}

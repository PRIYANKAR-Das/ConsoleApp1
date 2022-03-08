using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void Del(int a, int b);

    public class Arithmatic
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("a + b is " + (a + b));
        }
        public void Substract(int a, int b)
        {
            Console.WriteLine("a - b is " + (a - b));
        }
        public void Multiply(int a, int b)
        {
            Console.WriteLine("a * b is " + (a * b));
        }

    }
    internal class Delegates
    {
        public void Calculate(Del f, int a, int b)
        {
            f(a, b);
        }
        static void Main(string[] args)
        {
            Arithmatic o1 = new Arithmatic();
            Del f1 = o1.Add;
            Del f2 = o1.Add;
            f2 += o1.Substract;
            f2 += o1.Multiply;

            f1(2, 2);
            f2.Invoke(5, 5);

            Delegates o2 = new Delegates();

            o2.Calculate(f1, 6, 6);
            o2.Calculate(f2, 10, 10);

            Console.ReadKey();
        }
    }
}

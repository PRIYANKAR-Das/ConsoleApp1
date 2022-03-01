using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pass
    {
        // pass by value
        void swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        // pass by reference
        void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        // using out
        void swap(int x, int y, out int a, out int b)
        {
            int temp = x;
            x = y;
            y = temp;
            a = x;
            b = y;
        }
        static void Main(string[] args)
        {
            Pass obj = new Pass();

            int a = 1;
            int b = 2;
            Console.WriteLine("Before a: " + a + " b: " + b);
            obj.swap(a, b);
            Console.WriteLine("After a: " + a + " b: " + b);

            a = 10;
            b = 20;
            Console.WriteLine("Before a: " + a + " b: " + b);
            obj.swap(ref a, ref b);
            Console.WriteLine("After a: " + a + " b: " + b);

            a = 100;
            b = 200;
            Console.WriteLine("Before a: " + a + " b: " + b);
            obj.swap(a, b, out a, out b);
            Console.WriteLine("After a: " + a + " b: " + b);

            Console.ReadLine();
        }
    }
}

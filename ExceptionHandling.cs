using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ExceptionHandling
    {
        void m() { }
        static void Main(string[] args)
        {
            int[] a = new int[3];

            try
            {
                a[3] = 4;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }

            ExceptionHandling o = null;
            
            try
            {
                o.m();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Error" + e.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }

            ExceptionHandling o2 = new ExceptionHandling();

            string s = null;

            try
            {
                "Calculate".IndexOf(s);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }

            s = "String";

            try
            {
                s.Substring(s.Length + 1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }

            Console.ReadKey();
        }

        void k()
        {
            k();
        }
    }
}

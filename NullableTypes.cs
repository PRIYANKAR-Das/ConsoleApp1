using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NullableTypes
    {
        public int? x;
        static void Main(string[] args)
        {
            Nullable<int> num1 = null;
            if(num1 == null)
            {
                Console.WriteLine("Null");
            }

            int? num2 = 3;

            int? num3 = num1 ?? num2;

            Console.WriteLine(num3);

            if (num1 < num3)
            {
                Console.WriteLine("Comparable");
            }
            else if(num1 > num3)
            {
                Console.WriteLine("Comparable");
            }
            else if (num1 == num3)
            {
                Console.WriteLine("Comparable");
            }
            else
            {
                Console.WriteLine("Not Comparable");
            }

            NullableTypes obj = new NullableTypes();

            if (obj.x == null)
            {
                Console.WriteLine("Null");
            }

            obj.x = 1 + num3;

            Console.WriteLine(obj.x);

            Console.WriteLine(obj.x.HasValue);

            Console.WriteLine(num1.HasValue);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Present
    {
        static void Main(string[] args)
        {
            // What if we try to set null value to an int ?
            //int num1 = null;

            //Nullable<int> num2 = null; //Works

            // Various types of nullable types

            /*
            int? num3 = 1;
            Console.WriteLine(num3);
            Console.ReadKey();

            float? num4 = 2.5f;
            Console.WriteLine(num4);
            Console.ReadKey();

            double? num5 = 3.27;
            Console.WriteLine(num5);
            Console.ReadKey();
            */

            // null-coalescing operator ??

            /*
            int? num6 = 1;
            int? num7 = 2;
            int? num8 = 3;

            int? num9 = num6 ?? num7 ?? num8;
            Console.WriteLine(num9);
            */

            // Every Nullable<T> has .HasValue property

            Console.ReadKey();

            bool? b = false;
            Console.WriteLine(b.HasValue);
            Console.ReadKey();

            b = null;
            Console.WriteLine(b.HasValue);
            Console.ReadKey();

            b = true;
            Console.WriteLine(b.HasValue);


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace ConsoleApp1
{
    internal class Methods
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("PI");
            list.Add(3.141);
            list.Add(3);

            foreach (object o in list)
            {
                Console.WriteLine(o);
            }

            list.RemoveAt(2);

            foreach (object o in list)
            {
                Console.WriteLine(o);
            }

            Console.ReadKey();
        }
    }
}

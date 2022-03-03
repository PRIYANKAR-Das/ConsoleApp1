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
            list.Add(1);
            list.Add(2);
            list.Add(3);

            foreach (object o in list)
            {
                Console.WriteLine(o);
            }

            //list.RemoveAt(2);

            foreach (object o in list)
            {
                Console.WriteLine(o);
            }

            list.Sort();

            foreach (object o in list)
            {
                Console.WriteLine(o);
            }

            list.Reverse();

            foreach (object o in list)
            {
                Console.WriteLine(o);
            }

            SortedList<int, string> c = new SortedList<int, string>();

            c.Add(5, "United States");
            c.Add(4, "France");
            c.Add(3, "Germany");
            c.Add(2, "Ukraine");
            c.Add(1, "India");

            foreach (KeyValuePair<int, string> kvp in c)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace ConsoleApp1
{
    internal class DataStructures
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countries = new Dictionary<string, string>();

            countries.Add("au", "AUS");
            countries.Add("in", "IND");
            countries.Add("bd", "BAN");
            countries.Add("cn", "CHN");
            countries.Add("us", "USA");

            Console.WriteLine(countries["in"]);
            countries["in"] = "India";
            Console.WriteLine(countries["in"]);

            foreach (KeyValuePair<string, string> kvp in countries)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            countries.Remove("us");

            foreach (KeyValuePair<string, string> kvp in countries)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            countries.Clear();

            if (countries.Count == 0)
            {
                Console.WriteLine("Empty");
            }

            Stack<int> s = new Stack<int>();

            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);

            foreach (int i in s)
            {
                Console.WriteLine(i);
            }

            s.Pop();

            foreach (int i in s)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(s.Peek());

            Queue<int> q = new Queue<int>();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);

            foreach (int i in q)
            {
                Console.WriteLine(i);
            }

            q.Dequeue();

            foreach (int i in q)
            {
                Console.WriteLine(i);
            }

            q.Peek();

            Console.WriteLine();

            Hashtable h = new Hashtable();

            h.Add("PI", 3.141);
            h.Add("e", 2.732);
            h.Add("in", "India");

            foreach (DictionaryEntry de in h)
            {
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
            }

            h.Remove("in");

            foreach (DictionaryEntry de in h)
            {
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
            }

            Console.WriteLine();

            BitArray a = new BitArray(4, true);
            BitArray b = new BitArray(4, false);

            foreach (bool i in a)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("");

            foreach (bool i in b)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("");

            BitArray and = a.And(b);

            Console.WriteLine("AND");

            foreach (bool i in and)
            {
                Console.Write(i + " ");
            }

            a = new BitArray(4, true);
            b = new BitArray(4, false);

            Console.WriteLine("");

            BitArray or = a.Or(b);

            Console.WriteLine("OR");

            foreach (bool i in or)
            {
                Console.Write(i + " ");
            }

            a = new BitArray(4, true);
            b = new BitArray(4, false);

            Console.WriteLine("");

            BitArray xor = a.Xor(b);

            Console.WriteLine("XOR");

            foreach (bool i in xor)
            {
                Console.Write(i + " ");
            }

            a = new BitArray(4, true);
            b = new BitArray(4, false);

            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}

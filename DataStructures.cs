using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.ReadKey();
        }
    }
}

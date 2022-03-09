using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class File1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Writing directory C:\class work");

            Console.WriteLine("Enter file name: ");
            string fileName = Console.ReadLine();
            Console.WriteLine("Type the content");
            string content = Console.ReadLine();
            File.WriteAllText(@"C:\class work\" + fileName + ".txt", content);

            Console.ReadKey();
        }
    }
}

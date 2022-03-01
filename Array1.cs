using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Array1
    {
        static void Main(string[] args)
        {
            // 1D array
            char[] ch = new char[26];

            for (char i = 'A'; i <= 'Z'; ++i)
            {
                ch[i - 'A'] = i;
            }

            foreach (char c in ch)
            {
                Console.WriteLine(c);
            }

            //2D Array
            int[,] table = new int[21, 11];

            for (int i = 1; i <= 20; ++i)
            {
                for (int j = 1; j <= 10; ++j)
                {
                    table[i, j] = i * j;
                }
            }

            for (int i = 1; i <= 20; ++i)
            {
                for  (int j = 1; j <= 10; ++j)
                {
                    Console.WriteLine("{0} times {1} is {2}", i, j, table[i, j]);
                }
            }

            Console.ReadLine();
        }
    }
}

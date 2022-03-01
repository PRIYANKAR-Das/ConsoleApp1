using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to print the sum of n natural numbers");

            Console.WriteLine("n: ");

            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; ++i)
            {
                sum += i;
            }

            Console.WriteLine("The sum of {0} natural numbers is {1}", n, sum);

            Console.ReadLine();
        }
    }
}

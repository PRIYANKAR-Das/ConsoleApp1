using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ParamArray
    {
        static void Main(string[] args)
        {
            //int[] list = new int[] { 1, 2, 3, 4 };
            ParamArray obj = new ParamArray();
            double avg = obj.Avg(1,2,3,4);
            Console.WriteLine(avg);
            Console.ReadKey();
        }

        double Avg(params int[] list)
        {
            double total = 0;
            foreach (int num in list)
            {
                total += num;
            }

            return (total / list.Length);
        }
    }
}

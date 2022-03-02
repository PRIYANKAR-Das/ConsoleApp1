using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PassArray
    {
        static void Main(string[] args)
        {
            int[] list = new int[] {1,2,3,4};
            PassArray obj = new PassArray();
            double avg = obj.Avg(list);
            Console.WriteLine(avg);
            Console.ReadKey();
        }

        double Avg(int[] list)
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

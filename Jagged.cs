using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Jagged
    {
        static void Main(string[] args)
        {
            int[][] bars = new int[10][];

            for (int i = 0; i < bars.Length; ++i)
            {
                bars[i] = new int[i + 1];
                for (int j = 0; j < bars[i].Length; ++j)
                {
                    bars[i][j] = j + 1;
                }
            }

            foreach (int[] bar in bars)
            {
                foreach (int num in bar)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

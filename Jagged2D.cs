using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Jagged2D
    {
        static void Main(string[] args)
        {
            int[][,] jagged2d = new int[5][,];

            for (int i = 0; i < jagged2d.Length; ++i)
            {
                jagged2d[i] = new int[i + 1, i + 2];
            }

            for (int i = 0; i < jagged2d.Length; ++i)
            {
                for (int j = 0; j < jagged2d[i].GetLength(0); ++j)
                {
                    for (int k = 0; k < jagged2d[i].GetLength(1); ++k)
                    {
                        jagged2d[i][j, k] = i + 1;
                    }
                }
            }

            foreach (int[,] array2d in jagged2d)
            {
                for (int i = 0; i < array2d.GetLength(0); ++i)
                {
                    for (int j = 0; j < array2d.GetLength(1); ++j)
                    {
                        Console.Write(array2d[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

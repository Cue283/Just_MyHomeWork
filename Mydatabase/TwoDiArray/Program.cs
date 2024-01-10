using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intArr = new int[,] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("\t {0}", intArr[i, j]);
                }
                Console.WriteLine();

            }
        }
    }
}

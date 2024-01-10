using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input width \t:");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Input length\t:");
            int length = int.Parse(Console.ReadLine());
            drawRec(width, length);
            Console.WriteLine("\n--------Rectangular picture--------");
            int area = findArea(width, length);
            Console.WriteLine("Rectangular area is {0}", area);
        }
        public static void drawRec(int w, int l)
        {
            for (int i = 0;i< w; i++)
            {
                for(int j = 0;j < l; ++j)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
        public static int findArea(int w, int l) {
            return w * l;
        }
    }
}

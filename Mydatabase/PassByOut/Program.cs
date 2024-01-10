using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByOut
{
     class Program
    {
        static void Main(string[] args)
        {
            int radius = 3;
            int height = 10;
            double surfaceCurve;
            double volume;
            Computes(radius, height, out surfaceCurve, out volume);
            Console.WriteLine("Redius and Height of cylinder iss  {0} and {1} respectively.", radius, height);
            Console.WriteLine("Surface area is {0}", surfaceCurve);
            Console.WriteLine("Volume is {0}", volume);

        }
        static void Computes (int r ,int h , out double sC, out double vol)
        {
            sC = 2 * 3.142857 * r * h;
            vol = 3.142857 * r * r * h;
        }
    }
}

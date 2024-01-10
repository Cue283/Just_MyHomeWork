using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByRef
{
     class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 0;
            Console.WriteLine("This coordinate first point is {0},{1}",x,y);
            AddPoint(ref x, ref y);
            Console.WriteLine("After call addpoint medthod , the point id {0},{1}", x, y);

        }
        public static void AddPoint(ref int x1, ref int y1)
        {
            Console.WriteLine("Receive point from main medthod is {0},{1}",x1,y1);
            x1 += 10;
            y1 += 5;
            Console.WriteLine("Now the new point  is {0},{1} in AddPoint medthod", x1, y1);
        }
    }
}

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDiArray
{
     class Program
    {
        static void Main(string[] args)
        {
            float[] floatArr = new float[] { 11, 12, 13, 14, 15 };
            //for loop
            Console.WriteLine("Use for");
            for (int i = 0; i < floatArr.Length; i++)
            {
                Console.WriteLine (floatArr[i]);

            }
            //foreash loop 
            Console.WriteLine("Use foreash");
            foreach (float i in floatArr)
            {
                Console.WriteLine (i);
            }
        }
    }
}

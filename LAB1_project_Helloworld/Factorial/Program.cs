using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input factorial number : ");
            int data = int.Parse(Console.ReadLine());
            int result = 1;
            if (data == 0)
            {
                result = 1;
            }
            for (int i = 1; i <= data; i++)
            {
                result *=i;

            }
            Console.WriteLine("{0}! = {1}",data ,result);
        }
    }
}

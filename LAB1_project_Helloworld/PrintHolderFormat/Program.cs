using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintHolderFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 99;
            long y = 2546;
            Console.WriteLine ("\nData type :\t\tX is {0}, Y is {1}\n",x.GetType(),y.GetType());
            Console.WriteLine("Default Format: \tX is {0}, Y is {1}\n", x, y);
            Console.WriteLine("Currency Format: \tx is {0:c},Y is {1:c5}\n", x, y);
            Console.WriteLine("Decimal Format: \tx is {0:d},Y is {1:d5}\n", x, y);
            Console.WriteLine("Exponential Format: \tx is {0:e},Y is {1:e5}\n", x, y);
            Console.WriteLine("Hexdeilmal Format: \tx is {0:x},Y is {1:x5}\n", x, y);
            Console.WriteLine("Fixed point Format: \tx is {0:f},Y is {1:f5}\n", x, y);
        }
    }
}

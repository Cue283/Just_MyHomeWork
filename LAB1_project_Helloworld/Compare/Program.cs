using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Input 1stNunber: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Please Input 2ndNunber: ");
            int number2 = int.Parse(Console.ReadLine());
            if (number1 > number2) {
                Console.WriteLine("Number1 ins more than Number2");
            }
            else if (number1 < number2) {
                Console.WriteLine("Number1 ins less than Number2");
            }
            else { Console.WriteLine("Both numbers are equal"); }
        }
    }
}

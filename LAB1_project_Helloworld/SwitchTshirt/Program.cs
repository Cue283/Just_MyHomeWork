using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchTshirt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("T-shirt size: S = Small, M = Medium, L = Large, XL = extraLarge");
            Console.WriteLine("Please enter size:");
            string str = Console.ReadLine();
            str = str.ToUpper();
            switch (str)
            {
                case "S":
                    Console.WriteLine("Size :{0},You choose small size.", str);
                    break;
                case "M":
                    Console.WriteLine("Size :{0},You choose medium size.", str);
                    break;
                case "L":
                    Console.WriteLine("Size :{0},You choose large size.", str);
                    break;
                case "XL":
                    Console.WriteLine("Size :{0},You choose extra size.", str);
                    break;
                default:
                    Console.WriteLine("\nInvalid size.\nPlease choose size : s, m, l or xl.");
                    break;
            }
        }
    }
}

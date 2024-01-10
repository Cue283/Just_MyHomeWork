using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello_World");
            Console.Write("enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("hello{0}, I hope your are felling well.",name);
            Console.WriteLine();
            Console.Write("Enter your age (I promise not to tell anyone ):");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine();    
            Console.WriteLine("if your birthday is  after {0} then ",DateTime.Now);
            Console.WriteLine("you will be {0} later this year.",age +1);
            Console.WriteLine("or still be {0} until nex year .", age );

        }
    }
}

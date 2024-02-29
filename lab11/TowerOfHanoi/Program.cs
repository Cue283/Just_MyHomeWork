using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of Disk: ");
            int n = int.Parse(Console.ReadLine());
            MoveDisk(n, 'A', 'B', 'C');
        }
        static void MoveDisk(int n, char a,char c ,char b)
        {
            if (n == 0)
            {
                Console.WriteLine("This is no disk on Tower of Hanoi");
            }
            else if (n == 1)
            {
                Console.WriteLine("Move disk {0} from Tower{1} to Tower{2}",n,a,c);
            }
            else 
            {
                MoveDisk(n-1, a,c,b); 
                Console.WriteLine("Move disk {0} from Tower{1} to Tower{2}", n, a, c);
                MoveDisk(n-1,b,c,a);
            }

        }
    }
}

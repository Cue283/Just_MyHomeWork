using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequentialSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            Console.Write("Enter a number to search for: ");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            bool found = SeqSearch(numbers, searchNumber);

            if (found)
            {
                Console.WriteLine($"{searchNumber} is in the array.");
            }
            else
            {
                Console.WriteLine($"{searchNumber} is not in the array.");
            }
        }

        static bool SeqSearch(int[] arr, int sValue)
        {
            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] == sValue)
                {
                    return true;
                }
            }

            return false;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndexOf
{
    /*
    public class ArrayIndexOf
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                90, 199, 22, 50, 30
            };

            System.Console.WriteLine("Enter a number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            
            // int position =  Array.IndexOf(numbers, search);
            // int position =  Array.IndexOf(numbers, search, 2);
            int position =  Array.IndexOf(numbers, search, 1, 2);

            if (position > -1)
            {
                System.Console.WriteLine($"Number {search} has been found at position {position}.");
            }
            else
            {
                System.Console.WriteLine($"Number {search} hasn't been found.");
            }


            /*
            int position = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == search)
                {
                    position = i;
                }
            }

            if (position > -1)
            {
                System.Console.WriteLine($"Number {search} has been found at position {position}.");
            }
            else
            {
                System.Console.WriteLine($"Number {search} hasn't been found.");
            }
                  
        }
    }
    */
}
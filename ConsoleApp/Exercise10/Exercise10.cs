using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Exercise10
{
    /*
    public class Exercise10
    {
        /*
            - Create and initialise int array of numbers.
            - Create function SumOfNumbers with int return type.
            - int array parameter.
            - Function should return total of all numbers.
            - Call in main and output the total.
            - Extra: check array length.
                - return -1 if array empty.
                - check return in main and output message.
                - do we need to return -1, how else can we make this? 
        */
        
        /*
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5
            };

            int result = SumOfNumbers(numbers);

            if (result > -1)
            {
                System.Console.WriteLine($"The total is {result}.");
            }
            else
            {
                System.Console.WriteLine("Cannot add up an empty array!");
            }

            if (SumOfNumbers(numbers, out int total))
            {
                System.Console.WriteLine($"The total is {total}.");
            }
            else
            {
                System.Console.WriteLine("Cannot add up an empty array!");
            }

            Console.ReadLine();
        }

        static int SumOfNumbers(int[] numbers)
        {
            if (numbers.Length > 0)
            {
                int total = 0;

                foreach (var item in numbers)
                {
                    total += item;
                }

                return total;
            }
            
            return -1;
        }
        static bool SumOfNumbers(int[] numbers, out int total)
        {
            total = 0;

            if (numbers.Length > 0)
            {
                foreach (var item in numbers)
                {
                    total += item;
                }

                return true;
            }
            
            return false;
        }
    }
    */
}
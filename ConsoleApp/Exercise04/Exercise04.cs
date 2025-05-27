using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Exercise04
{
    public class Exercise04
    {
        /*  Exercise - Fizz buzz game

                - Create a for loop from 1 to X (15)
                - 3 and 5 = FizzBuzz
                - 3 = Fizz
                - 5 = Buzz
                - else = number
        */

        /*
        static void Main(string[] args)
        {
            System.Console.WriteLine("Type a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool threeDiv = false, fiveDiv = false;

            for (int i = 1; i <= number; i++)
            {
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;

                if (threeDiv && fiveDiv)
                {
                    System.Console.WriteLine("FizzBuzz");
                }
                else if (threeDiv)
                {
                    System.Console.WriteLine("Fizz");
                }
                else if (fiveDiv)
                {
                    System.Console.WriteLine("Buzz");
                }
                else
                {
                    System.Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
        */
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Exercise11
{
    /*
    public class Exercise11
    {
        /*
            - Create a int and try convert any string to an int.
            - Notice the error, write a try...catch handler around it.
            - Catch the error and output the error message.
            - Without changing the current code.

            - Why is this a bad situation and how can we know if its been converted?

            - Create a custom try passe function.
            - Find the real function and copy return type/params.
            - Read the tooltip it gives you, to give you ideas  on what to do.
        */
        
        /*
        static void Main(string[] args)
        {
            /*
            bool sucess = false;

            try
            {
                System.Console.WriteLine("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                sucess = true;
            }
            catch (System.FormatException e)
            {
                System.Console.WriteLine(e.Message);
            }

            System.Console.WriteLine(sucess? "Yay!" : "Oh no!");
            */

            /*
            System.Console.WriteLine("Enter a number: ");
            if (TryParse(Console.ReadLine(), out int result))
            {
                System.Console.WriteLine("Yay!");
            }
            else
            {
                System.Console.WriteLine("Oh no!");
            }

            Console.ReadLine();
        }

        static bool TryParse(string input, out int result)
        {
            result = -1;

            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
    */
}
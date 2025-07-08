using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceParameters
{
    /*
    public class ReferenceParameters
    {
        static void Main(string[] args)
        {
            /*
            int number = 10;
            string name = "Vinicius";
            Assign(ref number, ref name);
            System.Console.WriteLine(number);
            System.Console.WriteLine(name);
            */

            /*
            string name = "Vinicius";

            System.Console.Write("Enter your name: ");
            string newName = Console.ReadLine();

            if (ChangeName(ref name, newName))
            {
                System.Console.WriteLine($"Your name is {name}.");
            }
            else
            {
                System.Console.WriteLine("New name cannot be empty or null!");
            }

            Console.ReadLine();
        }

        static bool ChangeName(ref string name, string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }
            
            return false;
        }

        static void Assign(ref int number, ref string name)
        {
            name = "Vinicius";
            number = 20;
        }
    }
    */
}
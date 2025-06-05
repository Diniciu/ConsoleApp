using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.Title = $"{ReturnName()} - {ReturnAge()}";
            PrintIntroduction();

            Console.ReadLine();
        }

        static string ReturnName()
        {
            return "Vinicius";
        }

        static int ReturnAge()
        {
            return 24;
        }

        static void PrintIntroduction()
        {
            /*
            string name = ReturnName();
            int age = ReturnAge();
            string output = $"Hello, my name is {name} and my age is {age}";
            System.Console.WriteLine(output);
            */
            
            System.Console.WriteLine($"Hello, my name is {ReturnName()} and my age is {ReturnAge()}.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Exercise07
{
    /*
    public class Exercise07
    {
        /*
            - Create two list with integer data type, one for even numbers, one for odd.
            - Loop from 0 - 20.
                - If number is even, add to even list.
                - If number is odd, add to odd list.
            - Print even list.
            - Print odd list.
        */
        
        /*
        static void Main(string[] args)
        {
            
            List<int> listEven = new List<int>();
            List<int> listOdd = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    listEven.Add(i);
                }
                else
                {
                    listOdd.Add(i);
                }
            }

            System.Console.WriteLine("Printing even numbers: ");

            foreach (var item in listEven)
            {
                System.Console.Write($"{item} ");
            }

            System.Console.WriteLine(Environment.NewLine + "Printing odd numbers: ");

            foreach (var item in listOdd)
            {
                System.Console.Write($"{item} ");
            }
        }
    }
    */
}
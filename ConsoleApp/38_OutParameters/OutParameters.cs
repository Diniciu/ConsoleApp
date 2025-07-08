using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OutParameters
{
    /*
    public class OutParameters
    {
        static void Main(string[] args)
        {
            int number = 0;
            //bool sucess = test(out number);
            System.Console.WriteLine(number);
            // System.Console.WriteLine(sucess);

            // int.TryParse("123", out int result);

            List<string> shoppingList = new List<string>
            {
                "Coffee", "Milk"
            };

            System.Console.WriteLine(shoppingList.IndexOf("Milk"));
            // System.Console.WriteLine(FindInList("Milk", shoppingList, out int index));
            // System.Console.WriteLine(index);

            System.Console.WriteLine("Enter an item search: ");
            string search = Console.ReadLine();

            
            if (FindInList(search, shoppingList, out int index))
            {
                System.Console.WriteLine($"Found {search} at index {index}.");
            }
            else
            {
                System.Console.WriteLine("Not found.");
            }

            //int index = -1; // -> 0

            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (shoppingList[i].ToLower().Equals("coffee"));
                {
                    index = i;
                }
            }

            bool found = index > -1;
            System.Console.WriteLine(index > -1 ? "Found" : "Not found");
                

            Console.ReadLine();
        }
        
        
        static bool FindInList(string s, List<string> list, out int index)
        {
            index = -1; // -> 0

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(s.ToLower())) ;
                {
                    index = i;
                }
            }

            return index > -1;
        }

        static bool TryParse(string s, out int result)
        {
            result = 0;
            return true;
        }

        static bool test(out int number)
        {
            // number = 5;
            // return number;

            number = 5;
            return true;
        }
        
    }
    */
}
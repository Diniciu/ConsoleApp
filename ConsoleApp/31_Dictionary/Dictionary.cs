using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    /*
    public class Dictionary
    {
        static void Main(string[] args)
        {
            /*
            Dictionary<int, string> names = new Dictionary<int, string>();
            {   // KeyValuePair 
                names.Add(1, "Vinicius");
                names.Add(2, "Marco");
                names.Add(3, "Maria");
            }

            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                System.Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            System.Console.WriteLine();

            foreach (KeyValuePair<int, string> item in names)
            {
                System.Console.WriteLine($"{item.Key} - {item.Value}");
            }
            */

            /*
            Dictionary<string, string> teachers = new Dictionary<string, string>
            {

                { "Math", "Augusto"},
                {"Science", "Nick"},
                {"Chemistry", "Jack"}
            };

            // System.Console.WriteLine(teachers["Math"]);

            if (teachers.TryGetValue("Math", out string teacher))
            {
                System.Console.WriteLine(teacher);

                teachers["Math"] = "Joe";
            }
            else
            {
                System.Console.WriteLine("Math teacher not found.");
            }

            if (teachers.ContainsKey("Math"))
            {
                teachers.Remove("Math");
            }
            else
            {
                System.Console.WriteLine("Math not found.");
            }

            foreach (var item in teachers)
            {
                System.Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
    */
}
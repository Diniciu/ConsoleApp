using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Exercise06
{
    public class Exercise06
    {
        /*
            - Ask the user to enter password, and store it.
            - Ask the user to enter password again, and store.
            - Check if they're both contain someting.
                - If so check if they're the same.
                    - If they're, print "Password match."
                    - If they aren't, print "Passwords don't match."
                - If they are empty, print "Please, enter a password."
        */

        /*
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();

            System.Console.WriteLine("Enter password again: ");
            string passwordConfirm = Console.ReadLine();

            if (!password.Equals(string.Empty))
            {
                if (!password.Equals(string.Empty))
                {
                    if (password.Length >= 6 && passwordConfirm.Length >= 6)
                    {
                        if (password.Equals(passwordConfirm))
                        {
                            System.Console.WriteLine("Password match.");
                        }
                        else
                        {
                            System.Console.WriteLine("Password don't match.");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Please enter six or more characters!");
                    }
                }
                else
                {
                    System.Console.WriteLine("Please, enter a password confirmation.");
                }
            }

        }
        */
    }
}
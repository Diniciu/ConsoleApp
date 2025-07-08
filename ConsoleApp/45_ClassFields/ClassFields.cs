using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassFields
{
    /*
    public class ClassFields
    {
        class Person
        {
            private string name;
            private int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

        /*
            public void SetName(string name)
            {
                if (!string.IsNullOrEmpty(name))
                {
                    this.name = name;
                }
                else
                {
                    this.name = "Invalid name.";
                }

                this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name!";
            }
            */

            /*
            public void SetAge(int age)
            {

                if (age >= 0 && age <= 150)
                {
                    this.age = age;
                }
                else
                {
                    this.age = -1;
                }

                // this.age = age >= 0 && age <= 150 ? age : -1;
            }
            */

            /*
            public string GetName()
            {
                return name;
            }

            public int GetAge()
            {
                return age;
            }
            */

            /*
            public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name!";
            public string GetName() => name;
            public void SetAge(int age) => this.age = age >= 0 && age <= 150 ? age : -1;
            public int GetAge() => age;

            public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}";
            }
        }
        */

        /*
        static void Main(string[] args)
        {
            Person person = new Person("Vinicius", 24);
            System.Console.WriteLine(person.ReturnDetails());

            person.SetName("Franki");
            person.SetAge(25);
            System.Console.WriteLine(person.ReturnDetails());

            System.Console.WriteLine($"Your name is {person.GetName()} and your age is {person.GetAge()}.");

            Console.ReadLine();
        }
    }
    */
}
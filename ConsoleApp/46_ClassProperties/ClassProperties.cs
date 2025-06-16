using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProperties
{
    /*
    public class ClassProperties
    {
        class Person
        {
            private string name;
            private int age;

            
            public string Name
            {
                get => name;
                set => name = !string.IsNullOrEmpty(value) ? value : "Invalid name!";    
            }
            
            // public string Name{ get => Name; set => name = value; }
            // public int Age{ get => Age; set => Age = value; }
            
            public int Age
            {
                get => age;
                set => age = value >= 0 && value <= 150 ? value : -1;
            }
            

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;

                Name = name;
                Age = age;
            }
            
            /*
            public void SetName(string value)
            {
                this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name!";
            }

            public string GetName()
            {
                return name;
            }

            public void SetAge(int age)
            {
                this.age = age >= 0 && age <= 150 ? age : -1;
            }
            
            public int GetAge()
            {
                return age;
            }
            */

            /*
            public string ReturnDetails()
            {
                return $"Name: {Name}\nAge: {Age}";
            }
            */
        }

        /*
        static void Main(string[] args)
        {
            
            Person person = new Person("Vinicius", 24);
            System.Console.WriteLine(person.ReturnDetails());

            person.Name = "Franki";
            person.Age = 25;
            // System.Console.WriteLine(person.ReturnDetails());

            System.Console.WriteLine($"Your name is {person.Name} and your age is {person.Age}.");

            Console.ReadLine();
        }
    }
    */
}
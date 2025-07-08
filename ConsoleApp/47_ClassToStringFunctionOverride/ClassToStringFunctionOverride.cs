using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassToStringFunctionOverride
{
    /*
    public class ClassToStringFunctionOverride
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

            public override string ToString()
            {
                return $"Name: {Name}\tAge: {Age}";
            }

            public override bool Equals(object? obj)
            {
                if (obj is Person)
                {
                    Person person = obj as Person;
                    return Name.Equals(person.Name) && Age == person.Age;
                }

                return false;
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person("Vinicius", 24);
            Person test = new Person("Vinicius", 24);

            if (person.Equals(5))
            {
                System.Console.WriteLine("same");
            }
            else
            {
                System.Console.WriteLine("Not same");
            }

            Console.ReadLine();
        }
    }
    */
}
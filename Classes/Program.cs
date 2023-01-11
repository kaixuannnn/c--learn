using System;

namespace Classes
{
    public class Person
    {
        // field
        public string Name;

        // method
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}.", to, Name);
        }

        // static method
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var person = Person.Parse("Kai Xuan");
            person.Introduce("Tan");
        }
    }
}

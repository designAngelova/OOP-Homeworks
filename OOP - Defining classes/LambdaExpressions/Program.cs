using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Person
    {
        public string name;
        public int age;

        public Person()
        {
            
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", name, age);
        }
    }

    class Animal : Person
    {
        public string name;
        public string breed;

        public Animal(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("valeri", 23));
            people.Add(new Person("martin", 21));
            people.Add(new Person("asen", 30));
            people.Add(new Person("Hamgal", 50));
            people.Add(new Person("Debri", 11));
            people.Add(new Animal("Murdjo", "kon"));

            var sortedPeople = people.FindAll(x => (x.GetType() == typeof(Person))).OrderBy(x => x.age);

            foreach (var p in sortedPeople)
            {
                Console.WriteLine(p);
            }
        }
    }
}

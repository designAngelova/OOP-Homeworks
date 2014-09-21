namespace Persons
{
    using System;

    public class Person
    {
        private string name;
        private short age;
        private string email;

        public Person(string name, short age, string email = null)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, short age) :this(name, age, "")
        {

        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Your name cannot be blank!", "name");
                }

                this.name = value;
            }
        }

        public short Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Please enter a value in the range [1...100]", "age");
                }

                this.age = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value.IndexOf('@') == -1)
                {
                    throw new ArgumentException("Please enter a valid email or leave field empty", "email");
                }

                this.email = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\n" +
                                 "Age: {1}\n" +
                                 "Email: {2}",
                                this.name, this.age,
                                this.email ?? "N/A");
        }
    }

    public class TestPerson
    {
        public static void Main()
        {
            Person per1 = new Person("Barny", 23, "asdasd");

            Console.WriteLine(per1);
        }
    }
}

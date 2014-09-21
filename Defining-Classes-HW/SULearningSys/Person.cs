namespace SULearningSys
{
    using System;

    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        protected Person(string fName, string lName, int age)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Age = age;
        }

        protected string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be empty", "firstName");
                }

                this.firstName = value;
            }
        }

        protected string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be empty", "lastName");
                }

                this.lastName = value;
            }
        }

        protected int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Please enter a value between [1...100]", "age");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("\t***\nFirstName: {0}\n LastName: {1}\n Age: {2}",
                this.firstName, this.lastName, this.age);
        }
    }
}
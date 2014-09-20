namespace SoftUni_Learning_System
{
    using System;

    internal abstract class Person
    {
        protected string firstName;
        protected string lastName;
        protected short age;

        protected Person()
        {
            
        }

        protected Person(string firstName, string lastName, short age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("firstName");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("lastName");
                }

                this.lastName = value;
            }
        }

        public short Age
        {
            get { return this.age; }
            private set
            {
                if (age < 0 || age > 100)
                {
                    throw new ArgumentOutOfRangeException("age");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("FirstName: {0}\nLastName: {1}\nAge: {2}\n",
                this.firstName, this.lastName, this.age);
        }
    }
}

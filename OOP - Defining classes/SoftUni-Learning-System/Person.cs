using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Learning_System
{
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
            get { return firstName; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("firstName");
                }

                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("lastName");
                }

                lastName = value;
            }
        }

        public short Age
        {
            get { return age; }
            private set
            {
                if (age < 0 || age > 100)
                {
                    throw new ArgumentOutOfRangeException("age");
                }

                age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("FirstName: {0}\nLastName: {1}\nAge: {2}\n", firstName, lastName, age);
        }
    }
}

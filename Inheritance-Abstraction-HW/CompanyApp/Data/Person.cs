using System;
using CompanyApp.Interfaces;

namespace CompanyApp
{
    public abstract class Person : IPerson
    {
        private string id;
        private string firstName;
        private string lastName;

        protected Person(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        } 

        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Id cannot be empty");
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First Name cannot be empty");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be empty");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Id: {0}" + Environment.NewLine +
                "FirstName: {1}" + Environment.NewLine + "LastName: {2}\n" + Environment.NewLine,
                this.Id, this.FirstName, this.LastName);
        }
    }
}

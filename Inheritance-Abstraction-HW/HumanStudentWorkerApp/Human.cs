using System;

namespace HumanStudentWorkerApp
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
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
                    throw new ArgumentNullException("First name cannot be empty", "Human -> firstName");
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
                    throw new ArgumentNullException("Last name cannot be empty", "Human -> lastName");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("First Name: {0}, Last Name: {1}",
                this.FirstName, this.LastName);
        }
    }
}

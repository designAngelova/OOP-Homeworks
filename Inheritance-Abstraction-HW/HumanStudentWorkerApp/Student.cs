using System;

namespace HumanStudentWorkerApp
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Faculty number should be 5-10 digits long and consist of numbers/letters");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, Faculty Number: {1}\n",
                base.ToString(), this.FacultyNumber);
        }
    }
}

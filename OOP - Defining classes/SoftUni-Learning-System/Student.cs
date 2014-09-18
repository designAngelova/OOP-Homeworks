using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Learning_System
{
    internal abstract class Student : Person
    {
        protected string studentNumber;
        protected decimal averageGrade;


        protected Student(string fName, string lName, short age, string studentNumber, decimal averageGrade) : base(fName, lName, age)
        {   
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public string StudentNumber
        {
            get { return studentNumber; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("studentNumber");
                }

                studentNumber = value;
            }
        }

        public decimal AverageGrade
        {
            get { return averageGrade; }
            private set
            {
                if (value < 0.0m)
                {
                    throw new ArgumentNullException("averageGrade");
                }

                averageGrade = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                   String.Format("Student Number: {0}\n" +
                                 "Average Grade: {1}\n", this.studentNumber, this.averageGrade);
        }
    }
}

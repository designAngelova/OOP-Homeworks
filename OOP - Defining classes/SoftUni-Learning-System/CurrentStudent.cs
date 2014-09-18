using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Learning_System
{
    internal abstract class CurrentStudent : Student
    {
        protected string currentCourse;

        protected CurrentStudent(string fName, string lName, short age,
            string studentNumber, decimal averageGrade, string course) : base(fName, lName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = course;
        }

        public string CurrentCourse
        {
            get { return currentCourse; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("currentCourse");
                }

                currentCourse = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                   String.Format("Current Course: {0}\n", this.currentCourse);
        }
    }
}

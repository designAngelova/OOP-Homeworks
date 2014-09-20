namespace SoftUni_Learning_System
{
    using System;

    internal abstract class CurrentStudent : Student
    {
        protected string currentCourse;

        protected CurrentStudent(string fName,
            string lName,
            short age,
            string studentNumber,
            decimal averageGrade,
            string course) 
            : base(fName, lName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = course;
        }

        public string CurrentCourse
        {
            get { return this.currentCourse; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("currentCourse");
                }

                this.currentCourse = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                   String.Format("Current Course: {0}\n", this.currentCourse);
        }
    }
}

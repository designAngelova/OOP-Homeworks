namespace SULearningSys
{
    using System;

    public abstract class CurrentStudent : Student
    {
        private string course;

        protected CurrentStudent(string fName,
            string lName,
            int age,
            string studNum,
            double avgGrade,
            string course) 
            : base(fName, lName, age, studNum, avgGrade)
        {
            this.Course = course;
        }

        protected string Course
        {
            get { return this.course; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Current Course cannot be empty", "course");
                }

                this.course = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}\n Course: {1}", base.ToString(), this.course);
        }
    }
}

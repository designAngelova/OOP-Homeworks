namespace SULearningSys
{
    using System;

    public abstract class Student : Person
    {
        private string studentNumber;
        private double averageGrade;

        protected Student(string fName,
            string lName,
            int age,
            string studNum,
            double avgGrade)
            : base(fName, lName, age)
        {
            this.StudentNumber = studNum;
            this.AverageGrade = avgGrade;
        }

        protected string StudentNumber
        {
            get { return this.studentNumber; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Student number cannot be empty", "studentNumber");
                }

                this.studentNumber = value;
            }
        }

        public double AverageGrade
        {
            get { return this.averageGrade; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("average grade cannot be negative", "averageGrade");
                }

                this.averageGrade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}\n StudentNumber: {1}\n AverageGrade: {2}",
                base.ToString(), studentNumber, averageGrade);
        }
    }
}
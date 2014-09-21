namespace SULearningSys
{
    using System;

    public class DropoutStudent : Student
    {
        private string reason;

        public DropoutStudent(string fName,
            string lName,
            int age,
            string studNum,
            double avgGrade,
            string reason)
            : base(fName, lName, age, studNum, avgGrade)
        {
            this.Reason = reason;
        }

        public string Reason
        {
            get { return this.reason; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Dropout reason cannot be null!", "reason");
                }

                this.reason = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}\n Reason: {1}\n", base.ToString(), reason);
        }
    }
}
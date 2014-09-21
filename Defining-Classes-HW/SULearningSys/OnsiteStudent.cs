namespace SULearningSys
{
    using System;

    class OnsiteStudent : CurrentStudent
    {
        private int visits;

        public OnsiteStudent(string fName,
            string lName,
            int age,
            string studNum,
            double avgGrade,
            string course,
            int visits) 
            : base(fName, lName, age, studNum, avgGrade, course)
        {
            this.Visits = visits;
        }

        public int Visits
        {
            get { return this.visits; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Visits cannot be negative", "visits");
                }

                this.visits = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}\n Visits: {1}", base.ToString(), this.visits);
        }
    }
}

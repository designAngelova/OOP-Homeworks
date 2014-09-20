namespace SoftUni_Learning_System
{
    using System;

    class OnsiteStudent : CurrentStudent
    {
        private int visits;

        public OnsiteStudent(string fName,
            string lName,
            short age,
            string studentNumber,
            decimal averageGrade,
            string course,
            int visits)
            : base(fName, lName, age, studentNumber, averageGrade, course)
        {
            this.Visits = visits;
        }

        public int Visits
        {
            get { return this.visits; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("visits");
                }

                this.visits = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                String.Format("Visits: {0}", this.visits);
        }
    }
}

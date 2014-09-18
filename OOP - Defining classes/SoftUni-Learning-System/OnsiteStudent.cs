using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Learning_System
{
    class OnsiteStudent : CurrentStudent
    {
        private int visits;

        public OnsiteStudent(string fName, string lName, short age,
            string studentNumber, decimal averageGrade, string course, int visits)
            : base(fName, lName, age, studentNumber,
                averageGrade, course)
        {
            this.Visits = visits;
        }

        public int Visits
        {
            get { return visits; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("visits");
                }

                visits = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                   String.Format("Visits: {0}", this.visits);
        }
    }
}

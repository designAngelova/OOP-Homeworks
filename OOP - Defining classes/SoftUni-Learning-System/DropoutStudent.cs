using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Learning_System
{
    class DropoutStudent : Student
    {
        private string dropOutReason;

        public DropoutStudent(string fName, string lName, short age, string studentNumber, decimal averageGrade,
                              string reason)
                       : base(fName, lName, age, studentNumber, averageGrade)
        {
            this.dropOutReason = reason;
        }

        public string DropOutReason
        {
            get { return dropOutReason; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("reason");
                }

                dropOutReason = value;
            }
        }

        public void Reapply()
        {
            Console.WriteLine(base.ToString() +
                   String.Format("Dropout Reason: {0}", this.dropOutReason));
        }
    }
}

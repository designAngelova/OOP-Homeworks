namespace SoftUni_Learning_System
{
    using System;

    class DropoutStudent : Student
    {
        private string dropOutReason;

        public DropoutStudent(string fName,
            string lName,
            short age,
            string studentNumber,
            decimal averageGrade,
            string reason)
            : base(fName, lName, age, studentNumber, averageGrade)
        {
            this.dropOutReason = reason;
        }

        public string DropOutReason
        {
            get { return this.dropOutReason; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("reason");
                }

                this.dropOutReason = value;
            }
        }

        public void Reapply()
        {
            Console.WriteLine(base.ToString() +
                   String.Format("Dropout Reason: {0}", this.dropOutReason));
        }
    }
}

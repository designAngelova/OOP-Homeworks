using System;

namespace HumanStudentWorkerApp
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Weekly salary cannot be negative", "Worker -> weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours per day cannot be negative", "Worker -> workHoursPerDay");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5);
        }

        public override string ToString()
        {
            return string.Format("{0}, Week Salary: {1}, Work Hours Per Day: {2}, Money Per Hour: {3:C}\n",
                base.ToString(), this.WeekSalary, this.WorkHoursPerDay, this.MoneyPerHour());
        }
    }
}

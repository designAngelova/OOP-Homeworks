using System;
using CompanyApp.Interfaces;

namespace CompanyApp
{
    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;
        private Department department;

        protected Employee(string id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get { return this.salary; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative");
                }

                this.salary = value;
            }
        }

        public Department Department { get; set; }

        public override string ToString()
        {
            return string.Format("{0}Salary: {1}" + Environment.NewLine +"Department: {2}" + Environment.NewLine,
                base.ToString(), this.Salary, this.Department);
        }
    }
}

using System;
using System.Collections.Generic;
using CompanyApp.Interfaces;

namespace CompanyApp
{
    public class Manager : Employee, IManager
    {
        private ICollection<Employee> employees;

        public Manager(string id, string firstName, string lastName, decimal salary, Department department) 
            : base(id, firstName, lastName, salary, department)
        {
            this.employees = new SortedSet<Employee>();
        }

        public ICollection<Employee> Employees { get; private set; }

        public void AddEmployee(Employee employee)
        {
            this.Employees.Add(employee);
        }

        public override string ToString()
        {
            return string.Format("{0} Employees: \n{1}\n",
                base.ToString(),
                this.Employees == null ? "No employees" : 
                String.Join("\n  -", this.Employees));
        }
    }
}

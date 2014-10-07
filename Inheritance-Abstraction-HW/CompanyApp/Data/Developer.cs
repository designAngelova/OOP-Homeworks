using System;
using System.Collections.Generic;
using CompanyApp.Interfaces;

namespace CompanyApp
{
    public class Developer : RegularEmployee, IDeveloper
    {
        private ICollection<Project> projects;

        public Developer(string id,
            string firstName,
            string lastName,
            decimal salary,
            Department department) 
            : base(id, firstName, lastName, salary, department)
        {
            Projects = new HashSet<Project>()
            {
                new Project("Whitedog++", new DateTime(2011, 1, 12), State.Closed),
                new Project("Quintana", new DateTime(2010, 12, 12), State.Open),
                new Project("Stonebridge", new DateTime(2012, 6, 6), State.Closed)
            };
        }

        public ICollection<Project> Projects { get; private set; }

        public void AddProject(Project project)
        {
            this.projects.Add(project);
        }

        public void AddProjectRange(IEnumerable<Project> projects)
        {
            foreach (var project in projects)
            {
                this.projects.Add(project);
            }
        }

        public override string ToString()
        {
            return string.Format("{0}Projects: " + Environment.NewLine + "{1}" + Environment.NewLine,
                base.ToString(),
                String.Join(Environment.NewLine, this.Projects));
        }
    }
}

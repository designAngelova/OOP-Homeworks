using System;
using CompanyApp.Interfaces;

namespace CompanyApp
{
    public class Project : IProject
    {
        private string name;
        private DateTime startDate;
        private string details;
        private State state;

        public Project(string name, DateTime startDate,State state, string details = "N/A")
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
            this.State = state;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Project name cannot be empty");
                }

                this.name = value;
            }
        }

        public DateTime StartDate { get; set; }
        public string Details { get; set; }
        public State State { get; set; }

        public void CloseProject()
        {
            if (this.state == State.Closed)
            {
                this.state = State.Open;
            }
            else
            {
                this.state = State.Closed;
            }
        }

        public override string ToString()
        {
            return string.Format("  - Name: {0}" + Environment.NewLine +
                "  - Start Date: {1}" + Environment.NewLine + "  - Details: {2}" + Environment.NewLine +
                "  - State: {3}" + Environment.NewLine,
                this.Name, this.StartDate, this.Details, this.State);
        }
    }
}

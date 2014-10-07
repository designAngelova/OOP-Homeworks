using System.Collections.Generic;

namespace SchoolApp
{
    public class Teacher : Person
    {
        private ICollection<Discipline> disciplines;
 
        public Teacher(string name, string details = "N/A") : base(name, details)
        {
            this.disciplines = new HashSet<Discipline>();
        }

        public ICollection<Discipline> Disciplines { get; private set; }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }
    }
}

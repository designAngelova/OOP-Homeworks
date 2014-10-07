using System.Collections.Generic;

namespace SchoolApp
{
    public class Class : StudentCollection, IDetailable
    {
        private string id;
        private ICollection<Teacher> teachers;
        private string details;

        public Class(string id, string details = "N/A")
        {
            this.Id = id;
            this.teachers = new HashSet<Teacher>();
            this.details = details;
        }

        public string Id { get; set; }
        public ICollection<Teacher> Teachers { get; private set; }
        public string Details { get; set; }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }
    }
}

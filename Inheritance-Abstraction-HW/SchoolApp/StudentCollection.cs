using System.Collections.Generic;

namespace SchoolApp
{
    public abstract class StudentCollection : IStudentCollectible
    {
        private ICollection<Student> students;

        public StudentCollection()
        {
            this.students = new SortedSet<Student>();
        }

        public ICollection<Student> Students { get; private set; }
    }
}

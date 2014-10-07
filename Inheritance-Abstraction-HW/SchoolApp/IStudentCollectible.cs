using System.Collections.Generic;

namespace SchoolApp
{
    interface IStudentCollectible
    {
        ICollection<Student> Students { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Learning_System
{
    class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(string fName, string lName, short age,
            string studentNumber, decimal averageGrade, string course)
            : base(fName, lName, age, studentNumber, averageGrade, course)
        {
            
        }
    }
}

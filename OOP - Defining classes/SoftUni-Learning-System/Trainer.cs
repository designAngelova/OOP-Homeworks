using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Learning_System
{
    internal abstract class Trainer : Person
    {
        public Trainer(string fName, string lName, short age) : base(fName, lName, age)
        {
            
        }

        public void CreateCourse(string courseName)
        {
            Console.WriteLine("Course " + courseName + " has been created!");
        }
    }
}

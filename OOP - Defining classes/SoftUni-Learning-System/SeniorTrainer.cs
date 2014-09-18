using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Learning_System
{
    internal class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string fName, string lName, short age)
            : base(fName, lName, age)
        {
            
        }

        public void DeleteCourse(string course)
        {
            Console.WriteLine("Course " + course + " has been deleted!");
        }
    }
}

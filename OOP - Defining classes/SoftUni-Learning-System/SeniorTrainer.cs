namespace SoftUni_Learning_System
{
    using System;

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

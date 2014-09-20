namespace SoftUni_Learning_System
{
    using System;

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

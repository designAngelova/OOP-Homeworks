namespace SULearningSys
{
    using System;

    public abstract class Trainer : Person
    {
        protected Trainer(string fName, string lName, int age) : base(fName, lName, age)
        {
        }

        protected void CreateCourse(string courseName)
        {
            Console.WriteLine("The course {0} has been created!", courseName);
        }
    }
}
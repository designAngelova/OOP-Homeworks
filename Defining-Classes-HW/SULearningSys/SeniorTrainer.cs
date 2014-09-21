namespace SULearningSys
{
    using System;

    public class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string fName, string lName, int age) : base(fName, lName, age)
        {    
        }

        public void DeleteCourse(string courseName)
        {
            Console.WriteLine("The course {0} has been deleted!", courseName);
        }
    }
}
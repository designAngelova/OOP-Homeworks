using System;

namespace StudentClassApp
{
    public class TestStudentEvent
    {    
        public static void Main()
        {
            Student s1 = new Student("valeri", 23);

            s1.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    eventArgs.PropertyName, eventArgs.OldValue, eventArgs.NewValue);

            };

            s1.Name = "naevaleri";
            s1.Age = 900;
        } 
    }
}

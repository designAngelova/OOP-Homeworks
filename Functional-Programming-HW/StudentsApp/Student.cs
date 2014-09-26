using System.Collections.Generic;

namespace StudentsApp
{
    public class Student
    {
        public Student(string fName, string lName, int age, string fNumber,
            string phone, string email, IList<double> marks, string gNumber)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Age = age;
            this.FacultyNumber = fNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = gNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public IList<double> Marks { get; set; }
        public string GroupNumber { get; set; }

        public override string ToString()
        {
            return string.Format("First Name: {0}\n" +
                                 "Last Name: {1}\n" +
                                 "Age: {2}" +
                                 "Faculty Number: {3}\n" +
                                 "Phone: {4}\n" +
                                 "Email: {5}\n" +
                                 "Marks: {6}\n" +
                                 "Group Number: {7}\n",
                                 this.FirstName, this.LastName, this.Age,
                                 this.FacultyNumber, this.Phone, this.Email,
                                 this.Marks.DoubleListToString(),
                                 this.GroupNumber);
        }
    }
}

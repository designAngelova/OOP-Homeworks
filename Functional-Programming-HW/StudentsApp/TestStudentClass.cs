using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace StudentsApp
{
    // Please Comment/Uncomment lines of code as needed before testing
    public class TestStudentClass
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            IList<Student> students = new List<Student>()
            {
                new Student("Valeri", "Christ", 23, "213214", "0822372",
                    "asdasd@abv.bg", new List<double>() {2.00, 4.56, 2.00}, "1"),
                new Student("Marko", "Asenov", 14, "35566", "+359 2082737",
                    "morkov@abv.bg", new List<double>() {6.00, 5.00, 4.00}, "1"),
                new Student("Maria", "Deanova", 45, "00023", "09022372",
                    "mariika@abv.bg", new List<double>() {5.78, 5.24, 2.00}, "1"),
                new Student("Doroteya", "Ivanova", 31, "993214", "0272722",
                    "delorant@abv.bg", new List<double>() {4.21, 3.92, 6.00}, "2"),
                new Student("Asen", "Ludia", 18, "349923", "+359222372",
                    "bogobogo@gmail.bg", new List<double>() {2.00, 3.20, 2.00}, "2"),
                new Student("Stefan", "Dostoen", 21, "341122", "+34123222",
                    "stefand12o@gmail.bg", new List<double>() {5.32, 4.25, 4.99}, "1"),
                new Student("Willie", "Kirilov", 20, "34125483", "+3593232372",
                    "bartolomen1@gmail.bg", new List<double>() {2.00, 5.50, 5.33}, "2"),
                new Student("Deliiorgan", "Bejanov", 28, "342314", "+359111112",
                    "deviatos12@gmail.bg", new List<double>() {6.00, 4.70, 4.73}, "1"),
                new Student("Zjecho", "Delqnov", 26, "3555523", "+22222372",
                    "baloden445@abv.bg", new List<double>() {5.72, 4.70, 4.73}, "2"),
            };

            // Problem 4.	Students by Group
            students.GetPrintByGroup();

            // Problem 5.	Students by First and Last Name
            students.FirstBeforeLastName();

            // Problem 6.	Students by Age
            students.ByAgeInRange();

            // Problem 7.	Sort Students
            students.SortByName();
            students.SortByNameQuery();
            
            // Problem 8.	Filter Students by Email Domain
            students.FilterByEmail();

            // Problem 9.	Filter Students by Phone
            students.FilterByPhone();

            // Problem 10.	Excellent Students
            students.GetExcellentStudents();

            // Problem 11.	Weak Students
            var poorStudents = students.GetPoorStudents();

            foreach (var poorStudent in poorStudents)
            {
                Console.WriteLine(poorStudent);
            }

            // Problem 12.	Students Enrolled in 2014
            students.Enrolled14();

            // Problem 13.	* Students by Groups
            students.StudentsByGroups();

            // Problem 14.	* Students Joined To Specialties
            IEnumerable<StudentSpeciality> specialities = new List<StudentSpeciality>()
            {
                new StudentSpeciality("PHP Development", "213214"),
                new StudentSpeciality("HTML/CSS Mastery", "35566"),
                new StudentSpeciality("Java Game Development", "00023"),
                new StudentSpeciality("JavaScript Development", "993214"),
                new StudentSpeciality("Python Web Development", "349923"),
                new StudentSpeciality("Python Web Development", "341122"),
                new StudentSpeciality("Microsoft Server Administrator", "34125483"),
                new StudentSpeciality("Python Web Development", "342314"),
                new StudentSpeciality("HTML/CSS Mastery", "3555523")
            };

            students.GroupBySpec(specialities);
        }
    }
}

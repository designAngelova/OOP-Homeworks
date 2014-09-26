using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsApp
{
    public static class ListExtension
    {
        // Problem 4.	Students by Group
        public static void GetPrintByGroup(this IEnumerable<Student> students)
        {
            var groupTwoStudents = from student in students
                                   where student.GroupNumber == "2"
                                   select student;

            foreach (var groupTwoStudent in groupTwoStudents)
            {
                Console.WriteLine(groupTwoStudent);
            }
        }

        // Problem 5.	Students by First and Last Name
        public static void FirstBeforeLastName(this IEnumerable<Student> students)
        {
            var firstBeforeLast = from student in students
                                  where student.FirstName.CompareTo(student.LastName) == -1
                                  select student;

            foreach (var student in firstBeforeLast)
            {
                Console.WriteLine(student);
            }
        }

        // Problem 6.	Students by Age
        public static void ByAgeInRange(this IEnumerable<Student> students)
        {
            var sortedByAge = from student in students
                              where student.Age >= 18 && student.Age <= 23
                              select new { student.FirstName, student.LastName };

            foreach (var student in sortedByAge)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }

        // Problem 7.	Sort Students
        public static void SortByName(this IEnumerable<Student> students)
        {
            var sortedStudents = students.OrderByDescending(s => s.FirstName)
                                         .ThenByDescending(s => s.LastName);

            foreach (var sortedStudent in sortedStudents)
            {
                Console.WriteLine(sortedStudent);
            }
        }

        public static void SortByNameQuery(this IEnumerable<Student> students)
        {
            var sortedWithLinq = from student in students
                                 orderby student.FirstName, student.LastName descending
                                 select student;

            foreach (var sortedStudent in sortedWithLinq)
            {
                Console.WriteLine(sortedStudent);
            }
        }

        // Problem 8.	Filter Students by Email Domain
        public static void FilterByEmail(this IEnumerable<Student> students)
        {
            students.Where(s => s.Email.IndexOf("@abv.bg") > -1).ToList().ForEach(s =>
            {
                Console.WriteLine(s);
            });
        }

        // Problem 9.	Filter Students by Phone
        public static void FilterByPhone(this IEnumerable<Student> students)
        {
            students.Where(s =>
            {
                if (s.Phone.IndexOf("02") == 0 ||
                    s.Phone.IndexOf("+2592") == 0 ||
                    s.Phone.IndexOf("+359 2") == 0)
                {
                    return true;
                }

                return false;
            }).ToList().ForEach(s => Console.WriteLine(s));
        }

        // Problem 10.	Excellent Students
        public static void GetExcellentStudents(this IEnumerable<Student> students)
        {
            var excellentStudents = from student in students
                                    where student.Marks.Contains(6.00)
                                    select new { student.FirstName, student.LastName, student.Marks };

            foreach (var student in excellentStudents)
            {
                Console.WriteLine("{0} {1} -> {2}",
                    student.FirstName, student.LastName,
                    student.Marks.DoubleListToString());
            }
        }

        // Problem 12.	Students Enrolled in 2014
        public static void Enrolled14(this IEnumerable<Student> students)
        {
            var enrolledThisYear = from student in students
                                   where student.FacultyNumber[4] == '1' &&
                                         student.FacultyNumber[5] == '4'
                                   select new { student.FirstName, student.LastName, student.Marks };

            foreach (var student in enrolledThisYear)
            {
                Console.WriteLine("{0} {1} -> {2}", student.FirstName, student.LastName,
                    student.Marks.DoubleListToString());
            }
        }

        // Problem 13.	* Students by Groups
        public static void StudentsByGroups(this IEnumerable<Student> students)
        {
            var studentsIntoGroups = from student in students
                                     group student by student.GroupNumber
                                         into g
                                         select new { Group = g.Key, Students = g };

            foreach (var s in studentsIntoGroups)
            {
                Console.WriteLine("---------- Group {0} --------- ", s.Group);

                foreach (var student in s.Students)
                {
                    Console.WriteLine(student);
                }
            }
        }

        // Problem 14.	* Students Joined To Specialties
        public static void GroupBySpec(this IEnumerable<Student> students,
            IEnumerable<StudentSpeciality> specialities)
        {
            var groupedBySpec = from student in students
                                join spec in specialities
                                    on student.FacultyNumber equals spec.FacultyNumber
                                select new { StudentInfo = student, Speciality = spec.SpecialityName };

            foreach (var student in groupedBySpec)
            {
                Console.WriteLine("{0}Speciality: {1}\n", student.StudentInfo, student.Speciality);
            }
        }

        public static string ListToString<T>(this IEnumerable<T> collection)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in collection)
            {
                sb.Append(item.ToString());
            }

            return sb.ToString();
        }

        public static string DoubleListToString(this IEnumerable<double> collection)
        {
            return String.Join(", ", collection.Select(s => s.ToString("F")).ToList());
        }

        public static List<Student> GetPoorStudents(this IEnumerable<Student> collection)
        {
            ICollection<Student> newList = new List<Student>();

            foreach (var student in collection)
            {
                int counter = 0;

                foreach (var mark in student.Marks)
                {
                    if (mark == 2)
                    {
                        counter++;
                    }
                }

                if (counter == 2)
                {
                    newList.Add(student);
                }
            }

            return newList.ToList();
        }
    }
}
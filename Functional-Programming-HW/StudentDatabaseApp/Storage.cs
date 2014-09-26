using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace StudentDatabaseApp
{
    public static class Storage
    {
        private const string Path = "../../Students-data.txt";
        private static string[] dataLines;

        public static ICollection<Student> GetStudentData()
        {
            ReadFromFile();

            ICollection<Student> students = new Collection<Student>();

            for (int i = 1; i < dataLines.Length; i++)
            {
                string[] dataFields = Regex.Split(dataLines[i], @"\s+");

                int id = int.Parse(dataFields[0]);
                string fName = dataFields[1];
                string lName = dataFields[2];
                string email = dataFields[3];
                Gender gender = (Gender) Enum.Parse(typeof (Gender), dataFields[4]);
                StudentType studentType = (StudentType) Enum.Parse(typeof (StudentType), dataFields[5]);
                int examResult = int.Parse(dataFields[6]);
                double hwSent = double.Parse(dataFields[7]);
                double hwEvaluated = double.Parse(dataFields[8]);
                double teamScore = double.Parse(dataFields[9]);
                double attendencies = double.Parse(dataFields[10]);
                double bonus = double.Parse(dataFields[11]);

                students.Add(new Student(id, fName, lName, email, gender, studentType,
                    examResult, hwSent, hwEvaluated, teamScore, attendencies, bonus));
            }

            return students;
        }

        private static void ReadFromFile()
        {
            dataLines = File.ReadAllLines(Path);
        }

        public static void WriteToFile(StringBuilder text, string path)
        {
            File.WriteAllText(path, text.ToString());
        }
    }
}

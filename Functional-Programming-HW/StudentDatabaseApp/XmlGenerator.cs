using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StudentDatabaseApp
{
    public static class XmlGenerator
    {
        public static void GenerateStudentSheet(ref ICollection<Student> students)
        {
            string[] headers =
            {
                "ID", "First Name", "Last Name", "Email", "Gender", "Student Type",
                "Exam Score", "Homework Sent", "Homework Evaluated", "Teamwork",
                "Attendancies", "Bonus", "Result"
            };

            StringBuilder xmlSheet = new StringBuilder(XmlGenerator.ExcelHeader());

            xmlSheet.Append("<Row>\n");

            foreach (var header in headers)
            {
                xmlSheet.Append("<Cell ss:StyleID=\"s21\"><Data ss:Type=\"String\">" +
                    header + "</Data></Cell>\n");
            }

            xmlSheet.Append("</Row>\n");    

            foreach (var student in students)
            {
                xmlSheet.Append("<Row>\n");
                xmlSheet.Append("<Cell ss:StyleID=\"s16\"><Data ss:Type=\"Number\">" + student.Id + "</Data></Cell>\n");
                xmlSheet.Append("<Cell ss:StyleID=\"s16\"><Data ss:Type=\"String\">" + student.FirstName + "</Data></Cell>\n");
                xmlSheet.Append("<Cell ss:StyleID=\"s16\"><Data ss:Type=\"String\">" + student.LastName + "</Data></Cell>\n");
                xmlSheet.Append("<Cell ss:StyleID=\"s16\"><Data ss:Type=\"String\">" + student.Email + "</Data></Cell>\n");
                xmlSheet.Append("<Cell ss:StyleID=\"s16\"><Data ss:Type=\"String\">" + student.Gender + "</Data></Cell>\n");
                xmlSheet.Append("<Cell ss:StyleID=\"s16\"><Data ss:Type=\"String\">" + student.StudentType + "</Data></Cell>\n");
                xmlSheet.Append("<Cell ss:StyleID=\"s16\"><Data ss:Type=\"Number\">" + student.ExamResult + "</Data></Cell>\n");
                xmlSheet.Append("<Cell ss:StyleID=\"s16\"><Data ss:Type=\"Number\">" + student.HwSent + "</Data></Cell>\n");
                xmlSheet.Append("<Cell ss:StyleID=\"s16\"><Data ss:Type=\"Number\">" + student.HwEvaluated + "</Data></Cell>\n");
                xmlSheet.Append("<Cell ss:StyleID=\"s16\"><Data ss:Type=\"Number\">" + student.TeamScore + "</Data></Cell>\n");
                xmlSheet.Append("<Cell ss:StyleID=\"s16\"><Data ss:Type=\"Number\">" + student.Attendancies + "</Data></Cell>\n");
                xmlSheet.Append("<Cell ss:StyleID=\"s16\"><Data ss:Type=\"Number\">" + student.Bonus + "</Data></Cell>\n");
                xmlSheet.Append("<Cell ss:StyleID=\"s16\"><Data ss:Type=\"Number\">" +
                    student.Result.ToString("F") + "</Data></Cell>\n");
                xmlSheet.Append("</Row>\n");
            }

            xmlSheet.Append("</Table>\n");
            xmlSheet.Append(XmlGenerator.ExcelFooter());

            Storage.WriteToFile(xmlSheet, "../../studentTable.xls");
        }

        private static string ExcelHeader()
        {
            StringBuilder headerText = new StringBuilder(File.ReadAllText("../../WorksheetHeader.txt"));

            return headerText.ToString();
        }

        public static string ExcelFooter()
        {
            StringBuilder footerText = new StringBuilder(File.ReadAllText("../../WorksheetFooter.txt"));

            return footerText.ToString();
        }
    }
}

using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace StudentDatabaseApp
{
    public class TestStudentDatabaseApp
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            ICollection<Student> allStudentData = Storage.GetStudentData().OrderByDescending(x => x.Result).ToList();

            XmlGenerator.GenerateStudentSheet(ref allStudentData);
        }
    }
}

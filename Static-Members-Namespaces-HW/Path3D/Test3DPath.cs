using System;
using System.Globalization;
using System.Threading;

namespace Path3D
{
    public class Test3DPath
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Path3DSpace.AddPoint(new Point3D(1, 2, 9));
            Path3DSpace.AddPoint(new Point3D(1.9, 22, 19));

            Storage.WriteToFile(Path3DSpace.Points);

            string[] fileContents = Storage.ReadFromFile().GetPaths();

            foreach (var fileContent in fileContents)
            {
                Console.WriteLine(fileContent);
            }
        }
    }
}

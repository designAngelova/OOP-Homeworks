using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path3D
{
    class TestPath3D
    {
        public static void Main()
        {
            Path3D path1 = new Path3D();

            Point p1 = new Point(1, -11, 3);
            Point p2 = new Point(2, 3, 4);
            Point p3 = new Point(4, 5, 7);

            Path3D.AddPoints(p1, p2, p3);

            Storage.WriteToFile(Path3D.PrintPaths());
            var list = Path3D.GetPoints(Storage.ReadFromFile());

            foreach (var str in list)
            {
                Console.WriteLine(str);
            }
        }
    }
}

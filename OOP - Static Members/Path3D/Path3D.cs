namespace Path3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Path3D
    {
        public static List<Point> PathPoints;

        public Path3D()
        {
            PathPoints = new List<Point>();
        }

        public static void AddPoints(params Point[] args)
        {
            foreach (var arg in args)
            {
                PathPoints.Add(arg);
            }
        }

        public static List<string> GetPoints(string paths)
        {
            Regex regex = new Regex(@"X:\s([^,]+),\sY:\s([^,]+),\sZ:\s([^\]]+)");
            MatchCollection match = regex.Matches(paths);

            return (from Match m in match select m.Value).ToList();
        } 

        public static string PrintPaths()
        {
            return String.Join(", ", PathPoints);
        }
    }
}

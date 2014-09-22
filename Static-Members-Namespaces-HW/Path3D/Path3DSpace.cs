using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Path3D
{
    public static class Path3DSpace
    {
        private static ICollection<Point3D> points;

        static Path3DSpace()
        {
            points = new Collection<Point3D>();
        }

        public static void AddPoint(Point3D p)
        {
            points.Add(p);
        }

        public static ICollection<Point3D> Points
        {
            get { return points; }
            private set { points = value; }
        }
    }
}

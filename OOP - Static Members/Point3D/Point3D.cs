using System;

class Point3D
{
    private static readonly string startingPoint = "{0, 0, 0}";

    public Point3D(string coords)
    {
        this.Coordinates = coords;
    }

    public static string StartingPoint
    {
        get { return startingPoint; }
    }

    public string Coordinates { get; set; }

    public override string ToString()
    {
        return string.Format("Coordinates: {0}", Coordinates);
    }


    static void Main(string[] args)
    {
        Point3D p1 = new Point3D("{1, 2, 3}");

        Console.WriteLine(Point3D.StartingPoint);
    }
}


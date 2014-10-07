using System;

namespace ShapesApp
{
    public class Tester
    {
        public static void Main()
        {
            IShape[] shapes = new IShape[6];

            shapes[0] = new Circle(1.12);
            shapes[1] = new Circle(3.44);
            shapes[2] = new Rectangle(34.4, 44);
            shapes[3] = new Rectangle(11.4, 23);
            shapes[4] = new Square(111.4, 12);
            shapes[5] = new Square(34.4, 44);

            foreach (var shape in shapes)
            {
                Type currentShapeType = shape.GetType();
                string shapeName = currentShapeType == typeof (Square) ?
                    "Square" : currentShapeType == typeof (Rectangle) ?
                    "Rectangle" : "Circle";

                Console.WriteLine("The area of the {0} is {1}. The perimeter is {2}",
                    shapeName, shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}

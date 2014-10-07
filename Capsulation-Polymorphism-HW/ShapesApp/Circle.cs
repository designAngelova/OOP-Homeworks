using System;

namespace ShapesApp
{
    public class Circle : IShape
    {
        public double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (radius < 0)
                {
                    throw new ArgumentOutOfRangeException("Radius cannot be negative");
                }

                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public double CalculatePerimeter()
        {
            return  2 * Math.PI * this.Radius;
        }
    }
}

namespace ShapesApp
{
    public class Square : BasicShape, IShape
    {
        public Square(double width, double height) 
            : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return this.Width * this.Width;
        }

        public override double CalculatePerimeter()
        {
            return this.Width * 4;
        }
    }
}

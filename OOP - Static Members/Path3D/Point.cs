namespace Path3D
{
    class Point
    {
        private double x;
        private double y;
        private double z;

        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return string.Format("[X: {0}, Y: {1}, Z: {2}]", this.x, this.y, this.z);
        }
    }
}

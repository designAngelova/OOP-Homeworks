using System;

namespace GalacticGPS.Extension
{
    public static class SpaceDistance
    {
        private const int Earth = 150;

        public static int DistanceFromEarth(this Planet p)
        {
            return Math.Abs(Earth - (int) p);
        }
    }
}
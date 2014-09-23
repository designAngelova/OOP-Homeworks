using System;

namespace GalacticGPS.Extension
{
    public static class SpaceStrings
    {
        public static string SpaceFormat(this int distance)
        {
            return distance > 999 ? Math.Round((decimal) distance / 1000, 2) + " bilion km" :
                distance + " milion km";
        }

        public static string GraphBar(this decimal temperature)
        {
            return new string('#', Math.Abs((int) Math.Round(temperature / 10, MidpointRounding.AwayFromZero)));
        }
    }
}
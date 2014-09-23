using System;
using GalacticGPS.Data;

namespace GalacticGPS.Extensions
{
    public static class SpaceRotation
    {
        public static string LapDays(this Planet p)
        {
            int days = 0;

            foreach (var planet in PlanetList.GetPlanets())
            {
                if (planet.Value.Name == p)
                {
                    days = planet.Value.YearLength;
                    break;
                }
            }

            return String.Format("It takes {0} {1} days to complete one full lap around the sun. \n" +
                                 "That would be {2} earth years", p, days, Math.Round((double) days / 365, 2));
        }
    }
}
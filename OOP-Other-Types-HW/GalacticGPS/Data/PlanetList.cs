using System.Collections.Generic;

namespace GalacticGPS.Data
{
    public static class PlanetList
    {
        private const int DefaultCapacity = 8;

        private static IDictionary<string, PlanetWiki> encyclopedia;
            
        static PlanetList()
        {
            if (encyclopedia == null)
            {
                encyclopedia = new Dictionary<string, PlanetWiki>()
                {
                    {"Mercury", new PlanetWiki(Planet.Mercury, -180, 470, 88)},
                    {"Venus", new PlanetWiki(Planet.Venus, -210, 480, 225)},
                    {"Earth", new PlanetWiki(Planet.Earth, -50, 50, 365)},
                    {"Mars", new PlanetWiki(Planet.Mars, -143, 35, 687)},
                    {"Saturn", new PlanetWiki(Planet.Saturn, -185, -90, 10756)},
                    {"Jupiter", new PlanetWiki(Planet.Jupiter, -195, -100, 4335)},
                    {"Uranus", new PlanetWiki(Planet.Uranus, -215, -150, 30708)},
                    {"Neptune", new PlanetWiki(Planet.Neptune, -240, -200, 60224)}
                };
            }
        }

        public static IDictionary<string, PlanetWiki> GetPlanets()
        {
            return encyclopedia;
        } 
    }
}
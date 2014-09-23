using System.Text;
using GalacticGPS.Data;
using GalacticGPS.Extension;

namespace GalacticGPS.Graphs
{
    public static class Temperature
    {
        public static string DrawTemperatureGraph()
        {
            StringBuilder sb = new StringBuilder();

            var planets = PlanetList.GetPlanets();

            foreach (var planet in planets)
            {
                string planetInfo = planet.Key + ":\n  - Min Temp -> " +
                                    planet.Value.MinTemp.GraphBar() + "/ " + planet.Value.MinTemp + " C\n" +
                                    "  - Max Temp -> " +
                                    planet.Value.MaxTemp.GraphBar() + "/ " + planet.Value.MaxTemp + "C\n";
                sb.Append(planetInfo); 
            }

            return sb.ToString();
        }
    }
}
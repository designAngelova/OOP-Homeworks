namespace GalacticGPS.Data
{
    public struct PlanetWiki
    {
        private readonly Planet name;
        private readonly decimal minTemp;
        private readonly decimal maxTemp;
        private readonly int yearLength;

        public PlanetWiki(Planet name, decimal minTemp, decimal maxTemp, int yearLength)
        {
            this.name = name;
            this.minTemp = minTemp;
            this.maxTemp = maxTemp;
            this.yearLength = yearLength;
        }

        public Planet Name
        {
            get { return name; }
        }

        public decimal MinTemp
        {
            get { return minTemp; }
        }

        public decimal MaxTemp
        {
            get { return maxTemp; }
        }

        public int YearLength
        {
            get { return yearLength; }
        }
    }

}
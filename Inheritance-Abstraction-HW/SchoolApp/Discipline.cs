namespace SchoolApp
{
    public class Discipline : StudentCollection, IDetailable
    {
        private string name;
        private int numberOfLectures;
        private string details;

        public Discipline(string name, int numberOfLectures, string details = "N/A")
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.Details = details;
        }

        public string Name { get; set; }
        public int NumberOfLectures { get; set; }
        public string Details { get; set; }
    }
}

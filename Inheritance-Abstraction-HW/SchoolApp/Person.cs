namespace SchoolApp
{
    public abstract class Person : INameable, IDetailable
    {
        private string name;
        private string details;

        protected Person(string name, string details = "N/A")
        {
            this.Name = name;
            this.Details = details;
        }

        public string Name { get; set; }
        public string Details { get; set; }
    }
}

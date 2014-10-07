namespace SchoolApp
{
    public class Student : Person
    {
        private string classNumber;

        public Student(string name, string classNumber, string details = "N/A") : base(name, details)
        {
            this.ClassNumber = classNumber;
        }

        public string ClassNumber { get; private set; }
    }
}

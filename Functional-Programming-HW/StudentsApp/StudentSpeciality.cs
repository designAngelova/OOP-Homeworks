namespace StudentsApp
{
    public class StudentSpeciality
    {
        public StudentSpeciality(string name, string number)
        {
            this.SpecialityName = name;
            this.FacultyNumber = number;
        }

        public string SpecialityName { get; set; }
        public string FacultyNumber { get; set; }
    }
}

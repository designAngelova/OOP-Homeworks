namespace SULearningSys
{
    public class GraduateStudent : Student
    {
        public GraduateStudent(string fName,
            string lName,
            int age,
            string studNum,
            double avgGrade)
            : base(fName, lName, age, studNum, avgGrade)
        {
        }
    }
}
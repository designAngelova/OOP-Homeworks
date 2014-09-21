namespace SULearningSys
{
    public class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(string fName,
            string lName,
            int age,
            string studNum,
            double avgGrade,
            string course) 
            : base(fName, lName, age, studNum, avgGrade, course)
        {
        }
    }
}

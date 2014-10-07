namespace CompanyApp
{
    public class RegularEmployee : Employee
    {
        public RegularEmployee(string id, string firstName, string lastName, decimal salary, Department department) 
            : base(id, firstName, lastName, salary, department)
        {
        }
    }
}

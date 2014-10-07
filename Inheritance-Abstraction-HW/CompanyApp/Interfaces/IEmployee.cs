namespace CompanyApp.Interfaces
{
    public interface IEmployee : IPerson
    {
        decimal Salary { get; set; }
        Department Department { get; set; }
    }
}

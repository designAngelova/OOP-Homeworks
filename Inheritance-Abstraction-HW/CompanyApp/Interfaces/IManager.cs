using System.Collections.Generic;

namespace CompanyApp.Interfaces
{
    public interface IManager : IEmployee
    {
        ICollection<Employee> Employees { get; }
    }
}

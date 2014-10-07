using System.Collections.Generic;

namespace CompanyApp.Interfaces
{
    public interface IDeveloper : IEmployee
    {
        ICollection<Project> Projects { get; } 
    }
}

using System.Collections.Generic;

namespace CompanyApp.Interfaces
{
    public interface ISalesEmployee : IEmployee
    {
        ICollection<Sale> Sales { get; } 
    }
}

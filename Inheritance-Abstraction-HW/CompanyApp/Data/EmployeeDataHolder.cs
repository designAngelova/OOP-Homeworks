using System.Collections.Generic;

namespace CompanyApp
{
    public class EmployeeDataHolder
    {
        public static ICollection<Employee> Employees = new List<Employee>();
        
        public EmployeeDataHolder()
        {
            Employees.Add(new Manager("1122", "Marin", "Borisov", 2000.12m, Department.Marketing));
            Employees.Add(new Manager("22445", "Vanq", "Kirilova", 2300.00m, Department.Production));
            Employees.Add(new SalesEmployee("22", "Asen", "Kostov", 400.00m, Department.Accounting));
            Employees.Add(new SalesEmployee("32", "Doloreq", "Ivanova", 550.00m, Department.Sales));
            Employees.Add(new Developer("099", "Petar", "Petrov", 1500.00m, Department.Production));
            Employees.Add(new Developer("129", "Dimitar", "Dimitrov", 1490.00m, Department.Production));
        }
    }
}

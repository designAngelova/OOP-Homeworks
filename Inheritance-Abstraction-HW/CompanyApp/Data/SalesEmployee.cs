using System;
using System.Collections.Generic;
using CompanyApp.Interfaces;

namespace CompanyApp
{
    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private ICollection<Sale> sales;

        public SalesEmployee(string id,
            string firstName,
            string lastName,
            decimal salary,
            Department department) 
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = new HashSet<Sale>()
            {
                new Sale("Whitedog++", new DateTime(2011, 1, 12), 122.2m),
                new Sale("Apple 11", new DateTime(2012, 2, 22), 222.2m),
                new Sale("Qintana", new DateTime(2014, 8, 22), 22.2m)
            };
        }

        public ICollection<Sale> Sales { get; private set; }

        public void AddSale(Sale sale)
        {
            this.Sales.Add(sale);
        }

        public void AddSaleRange(IEnumerable<Sale> sales)
        {
            foreach (var sale in sales)
            {
                this.sales.Add(sale);
            }
        }

        public override string ToString()
        {
            return string.Format("{0}Sales: " + Environment.NewLine +"  -{1}" + Environment.NewLine,
                base.ToString(),
                String.Join(Environment.NewLine + "  -", this.Sales));
        }
    }
}

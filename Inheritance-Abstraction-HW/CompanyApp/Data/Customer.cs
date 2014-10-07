using CompanyApp.Interfaces;

namespace CompanyApp
{
    public class Customer : Person, ICustomer
    {
        private decimal netPurchasedAmount;

        public Customer(string id, string firstName, string lastName, decimal netPurchasedAmount) 
            : base(id, firstName, lastName)
        {
            this.NetPurchasedAmount = netPurchasedAmount;
        }

        public decimal NetPurchasedAmount { get; private set; }

        public override string ToString()
        {
            return string.Format("{0}\n Net Purchased Amount: {1}\n", base.ToString(), NetPurchasedAmount);
        }
    }
}

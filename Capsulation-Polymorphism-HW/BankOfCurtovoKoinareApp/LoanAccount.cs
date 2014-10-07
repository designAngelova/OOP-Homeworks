using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfCurtovoKoinareApp
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal baseInterest = base.CalculateInterest(months);
            int monthsWithNoInterest = this.Customer == Customer.Individual ? 3 : 2;
            decimal amountToSubstract = base.CalculateInterest(monthsWithNoInterest);

            return baseInterest - amountToSubstract;
        }
    }
}

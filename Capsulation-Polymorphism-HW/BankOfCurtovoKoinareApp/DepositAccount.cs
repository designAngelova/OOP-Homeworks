namespace BankOfCurtovoKoinareApp
{
    public class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public decimal WithdrawMoney(decimal amount)
        {
            this.Balance -= amount;

            return amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }

            decimal initialInterest = base.CalculateInterest(months);

            return initialInterest;
        }
    }
}

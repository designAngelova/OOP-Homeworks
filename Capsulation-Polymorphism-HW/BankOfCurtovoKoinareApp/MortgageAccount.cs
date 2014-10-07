namespace BankOfCurtovoKoinareApp
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal baseInterest = base.CalculateInterest(months);
            decimal mortgageFinalInterest = 0;
            decimal amountToSubstract = 0;
            decimal currentInterest = 0;

            if (this.Customer == Customer.Individual)
            {
                amountToSubstract = base.CalculateInterest(6);
                currentInterest = baseInterest - amountToSubstract;

                if (currentInterest < 0)
                {
                    currentInterest = 0;
                }

                mortgageFinalInterest = currentInterest;
            }
            else
            {
                amountToSubstract = base.CalculateInterest(12) / 2;
                currentInterest = baseInterest - amountToSubstract;

                if (currentInterest < 0)
                {
                    currentInterest = 0;
                }

                mortgageFinalInterest = currentInterest;
            }

            return mortgageFinalInterest;
        }
    }
}

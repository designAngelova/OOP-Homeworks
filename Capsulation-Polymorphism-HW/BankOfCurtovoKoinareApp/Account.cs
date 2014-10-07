using System;

namespace BankOfCurtovoKoinareApp
{
    public abstract class Account : IAccount
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance cannot be initiated negative");
                }

                this.balance = value;
            }
        }

        public decimal InterestRate { get; set; }
        public Customer Customer { get; set; }  

        public virtual void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public virtual decimal CalculateInterest(int months)
        {
            decimal interest = this.Balance * (1 + (this.InterestRate / 100) * months);

            return interest;
        } 
    }
}

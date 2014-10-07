namespace BankOfCurtovoKoinareApp
{
    public interface IAccount
    {
        Customer Customer { get; set; }
        decimal Balance { get; set; }
        decimal InterestRate { get; set; }

        void Deposit(decimal amount);
    }
}

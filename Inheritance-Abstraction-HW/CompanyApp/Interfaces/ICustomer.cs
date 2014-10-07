namespace CompanyApp.Interfaces
{
    public interface ICustomer : IPerson
    {
        decimal NetPurchasedAmount { get; }
    }
}

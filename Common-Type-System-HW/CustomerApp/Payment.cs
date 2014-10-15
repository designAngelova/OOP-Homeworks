namespace CustomerApp
{
    public class Payment
    {
        public Payment(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return string.Format("Product Name: {0} -> Price: {1}",
                ProductName, Price);
        }
    }
}

using System;
using CompanyApp.Interfaces;

namespace CompanyApp
{
    public class Sale : ISale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product name cannot be empty");
                }

                this.productName = value;
            }
        }

        public DateTime Date { get; set; }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format(" Product Name: {0}" + Environment.NewLine +
                "  - Date: {1}" + Environment.NewLine + "  - Price: {2:C}" + Environment.NewLine,
                this.ProductName, this.Date, this.Price);
        }
    }
}

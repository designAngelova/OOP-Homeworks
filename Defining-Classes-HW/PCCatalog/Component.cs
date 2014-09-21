namespace PCCatalog
{
    using System;

    public class Component : IComponent
    {
        private string name;
        private decimal price;
        private string details;

        public Component(string name, decimal price, string details = null)
        {
            this.Name = name;
            this.Price = price;
            this.details = details;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Your name cannot be empty", "name");
                }

                this.name = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative", "price");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return String.Format(" - Name: {0}\n" +
                                 " - Price: {1}\n" +
                                 " - Details: {2}\n",
                                this.name, this.price,
                                this.details ?? "N/A");
        }
    }
}

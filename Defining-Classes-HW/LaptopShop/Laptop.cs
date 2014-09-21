namespace LaptopShop
{
    using System;

    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string graphicsCard;
        private string hdd;
        private string ram;
        private Battery battery;
        private string screenSize;
        private decimal price;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, string manufacturer, decimal price)
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
        }

        public Laptop(string model, string processor, string graphicsCard, decimal price)
            : this(model, price)
        {
            this.Processor = processor;
            this.GraphicsCard = graphicsCard;
        }

        public Laptop(string model, Battery battery)
        {
            this.Model = model;
            this.battery = battery;
        }

        public Laptop(string model,
            string manufacturer,
            string processor,
            string graphicsCard,
            Battery battery,
            string screenSize,
            decimal price) : this(model, processor, graphicsCard, price)
        {
            this.Manufacturer = manufacturer;
            this.battery = battery;
            this.ScreenSize = screenSize;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("model", "laptop`s model cannot be an empty string");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("manufacturer", "laptop`s manufacturer cannot be an empty string");
                }

                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("processor", "laptop`s processor cannot be an empty string");
                }

                this.processor = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("graphicsCard", "laptop`s graphics card cannot be an empty string");
                }

                this.graphicsCard = value;
            }
        }

        public string ScreenSize
        {
            get { return screenSize; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("screenSize", "laptop`s screen size cannot be an empty string");
                }

                this.screenSize = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("price", "laptop`s price cannot be negative");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Model: {0}\n" +
                                 "Manufacturer: {1}\n" +
                                 "Processor: {2}\n" +
                                 "Graphics Card: {3}\n" +
                                 "Battery: {4}\n" + 
                                 "Screen Size: {5}\n" + 
                                 "Price: {6}\n",
                                 this.model,
                                 this.manufacturer ?? "N/A",
                                 this.processor ?? "N/A",
                                 this.graphicsCard ?? "N/A",
                                 this.battery,
                                 this.screenSize ?? "N/A",
                                 this.price);
        }
    }
}

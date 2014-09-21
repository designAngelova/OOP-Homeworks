namespace LaptopShop
{
    using System;

    public class Battery
    {
        private string model;
        private double longevity;

        public Battery(string model, double longevity = 0.0d)
        {
            this.model = model;
            this.longevity = longevity;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(model))
                {
                    throw new ArgumentNullException("model", "Empty string is not a valid model");
                }

                this.model = value;
            }
        }

        public double Longevity
        {
            get { return this.longevity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("battery -> longevity", "value cannot be negative");
                }

                this.longevity = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Model: {0} / Hours: {1}", this.model, this.longevity);
        }
    }
}

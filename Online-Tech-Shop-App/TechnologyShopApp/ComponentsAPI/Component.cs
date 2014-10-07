using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnologyShopApp.Interfaces;

namespace TechnologyShopApp.ComponentsAPI
{
    public abstract class Component : IProduct
    {
        private string model;
        private decimal price;

        protected Component(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(ComponentConstants.InvalidModelValueMessage, model);
                }

                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(ComponentConstants.InvalidPriceValueMessage);
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return String.Format("  - Model: {0} --> {1:C}", this.Model, this.Price);
        }
    }
}

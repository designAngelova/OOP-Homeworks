using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TechnologyShopApp.Constants;
using TechnologyShopApp.Interfaces;
using TechnologyShopApp.OptionStructures;

namespace TechnologyShopApp
{
    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private LoyaltyRank loyalty;
        private ICollection<IProduct> products;

        public Company(string name, string registrationNumber, LoyaltyRank loyalty)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.loyalty = loyalty;
            this.products = new Collection<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(CompanyConstants.InvalidNameMessage);
                }

                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }

            set
            {
                if (String.IsNullOrEmpty(value) || value.Length != 10)
                {
                    throw new ArgumentException(CompanyConstants.InvalidRegistrationNumberMessage);
                }

                this.registrationNumber = value;
            }
        }

        public LoyaltyRank Loyalty
        {
            get { return this.loyalty; } 
        }

        public ICollection<IProduct> Products
        {
            get
            {
                return this.products;
            } 
        }

        public void AddProduct(IProduct product)
        {
            this.products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.products.Remove(product);
        }

        public IProduct FindProduct(string model)
        {
            foreach (var product in this.products)
            {
                if (product.Model == model)
                {
                    return product;
                }
            }

            return null;
        }

        public string ShowCatalog()
        {
            StringBuilder catalog = new StringBuilder(this.ToString());

            catalog.Append(String.Join("\n", this.products.OrderBy(p => p.Price)));

            return catalog.ToString();
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} computer{2}\n",
                this.Name, this.products.Count == 0 ? "no" : this.products.Count.ToString(),
                this.products.Count == 1 ? "" : "s");
        }
    }
}

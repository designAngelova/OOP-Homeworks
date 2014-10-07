using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TechnologyShopApp.ComponentsAPI;
using TechnologyShopApp.Constants;
using TechnologyShopApp.Interfaces;

namespace TechnologyShopApp
{
    public abstract class Computer : IComputer, IProduct
    {
        private ICollection<Component> components;
        private string model;
        private decimal price;

        protected Computer(string model)
        {
            this.model = model;
            this.components = new Collection<Component>();
        }

        public ICollection<Component> Components
        {
            get { return this.components; }
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
                    throw new ArgumentNullException(ComputerConstants.InvalidComputerModelMessage);
                }

                this.model = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            protected set { this.price = value; }
        }

        public void AddComponent(Component component)
        {
            this.price += component.Price;

            this.components.Add(component);
        }

        public void RemoveComponent(string model, bool multiple = false)
        {
            ICollection<Component> itemsToDelete = new Collection<Component>();

            foreach (var component in this.components)
            {
                if (component.Model == model)
                {
                    itemsToDelete.Add(component);

                    if (!multiple)
                    {
                        break;
                    }
                }
            }

            foreach (var component in itemsToDelete)
            {
                this.components.Remove(component);
            }
        }

        private decimal CalculatePrice()
        {
            return this.components.Sum(c => c.Price);
        }

        public override string ToString()
        {
            return String.Format("Model: {0}\n" +
                                 "{1}\n" +
                                 "Price {2}",
                                 this.Model, 
                                 this.components.Count == 0 ? "No components" : String.Join("\n", this.components),
                                 this.Price);
        }
    }
}

namespace PCCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Computer
    {
        private string name;
        private IList<Component> components; 
        private decimal price;

        public Computer(string name, IList<Component> components)
        {
            this.Name = name;
            this.components = components;
        }

        public Computer(string name)
        {
            this.Name = name;
            components = new List<Component>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Computer name cannot be empty", "Computer -> name");
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
                    throw new ArgumentOutOfRangeException("Computer price cannot be empty", "Computer -> price");
                }
            }
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\n" +
                                 "Components:\n{1}" +
                                 "Price: {2}",
                                 this.name,
                                 String.Join("\n", this.components.Select(x => x.ToString()).ToArray()),
                                 CalculatePrice(this.components));
        }

        public void AddComponent(Component component)
        {
            this.components.Add(component);
            this.price += component.Price;
        }

        private decimal CalculatePrice<T>(IList<T> componentList) where T : IComponent
        {
            return componentList.Sum(x => x.Price);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnologyShopApp.ComponentsAPI;

namespace TechnologyShopApp
{
    public class Laptop : Computer
    {
        private Battery battery;
        private LaptopType type;

        public Laptop(string model, LaptopType type, Battery battery) : base(model)
        {
            this.battery = battery;
            this.Price += battery.Price;
        }
    } 
}

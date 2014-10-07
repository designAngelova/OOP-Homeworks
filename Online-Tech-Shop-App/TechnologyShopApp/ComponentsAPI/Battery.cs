using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyShopApp.ComponentsAPI
{
    public class Battery : Component
    {
        public Battery(string model, decimal price) : base(model, price)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyShopApp.ComponentsAPI
{
    public class Processor : Component
    {
        public Processor(string model, decimal price) : base(model, price)
        {
        }
    }
}

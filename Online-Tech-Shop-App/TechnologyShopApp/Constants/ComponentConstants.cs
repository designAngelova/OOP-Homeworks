using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyShopApp.ComponentsAPI
{
    public abstract class ComponentConstants
    {
        public const string InvalidModelValueMessage = "Component model cannot be empty";
        public const string InvalidPriceValueMessage = "Component Price cannot be less or equal to zero";
    }
}

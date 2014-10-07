using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnologyShopApp.ComponentsAPI;

namespace TechnologyShopApp.Interfaces
{
    public interface IComputer : IProduct
    {
        ICollection<Component> Components { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyShopApp.Interfaces
{
    public interface IProduct
    {
        string Model { get; set; }
        decimal Price { get; }
    }
}

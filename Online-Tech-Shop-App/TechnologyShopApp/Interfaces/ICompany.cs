using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnologyShopApp.OptionStructures;

namespace TechnologyShopApp.Interfaces
{
    public interface ICompany
    {
        string Name { get; set; }
        string RegistrationNumber { get; set; }
        LoyaltyRank Loyalty { get; }
        ICollection<IProduct> Products { get; }

        void AddProduct(IProduct product);
        void RemoveProduct(IProduct product);
        IProduct FindProduct(string model);
        string ShowCatalog();
    }
}

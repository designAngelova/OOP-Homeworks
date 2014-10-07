using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnologyShopApp.ComponentsAPI;
using TechnologyShopApp.OptionStructures;

namespace TechnologyShopApp
{
    class TestTechShop
    {
        static void Main(string[] args)
        {
            DesktopComputer myComputer = new DesktopComputer("Aksus 11");

            myComputer.AddComponent(new Processor("Intel Inside 1020 5Ghz", 993.2m));
            myComputer.AddComponent(new HardDrive("Maxtor 500GB", 223.2m));
            myComputer.AddComponent(new GraphicsCard("NVidia G-force 4 GB", 323.2m));
            myComputer.AddComponent(new Memory("Seagate 16 GB", 463.2m));

            Laptop myLaptop = new Laptop("Lenovo", LaptopType.DesktopReplacement, new Battery("Lilon", 12.9m));

            myLaptop.AddComponent(new Processor("Intel Inside 1020 5Ghz", 123.2m));
            myLaptop.AddComponent(new HardDrive("Maxtor 500GB", 223.2m));
            myLaptop.AddComponent(new GraphicsCard("NVidia G-force 4 GB", 323.2m));
            myLaptop.AddComponent(new Memory("Seagate 16 GB", 463.2m));

            Company vartaPower = new Company("VartaPower", "1111111111", LoyaltyRank.Gold);

            vartaPower.AddProduct(myComputer);
            vartaPower.AddProduct(myLaptop);

            Console.WriteLine(vartaPower.ShowCatalog());
        }
    }
}

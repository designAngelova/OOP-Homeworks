using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnologyShopApp.Interfaces;

namespace TechnologyShopApp
{
    class ConvertableLaptop : Computer, IConvertable
    {
        private bool isConverted = false;

        public ConvertableLaptop(string model) : base(model)
        {
        }

        public void Convert()
        {
            this.isConverted = !this.isConverted;
        }
    }
}

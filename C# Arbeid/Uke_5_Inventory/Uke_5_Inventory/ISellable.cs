using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uke_5_Inventory
{
    internal interface ISellable
    {
        double Price { get; set; }
        double CalculateSalePrice();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uke_5_Inventory
{
    internal abstract class InventoryItem : ISellable
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public double CalculateSalePrice()
        {
            return Price * Quantity;
        }
    }
}

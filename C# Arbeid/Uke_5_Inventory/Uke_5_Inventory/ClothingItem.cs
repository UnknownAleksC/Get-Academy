using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Uke_5_Inventory
{
    internal class ClothingItem : InventoryItem
    {
        public string Size { get; set; }
        public string Color { get; set; }

        public ClothingItem(string name, int quantity, double price, string size, string color)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Size = size;
            Color = color;
        }
    }
}

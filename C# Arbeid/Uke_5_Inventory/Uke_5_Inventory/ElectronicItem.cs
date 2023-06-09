using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uke_5_Inventory
{
    internal class ElectronicItem : InventoryItem
    {
        public string Insurance { get; set; }
        public int Voltage { get; set; }

        public ElectronicItem(string name, int quantity, double price, string insurance, int voltage)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Insurance = insurance;
            Voltage = voltage;
        }
    }
}

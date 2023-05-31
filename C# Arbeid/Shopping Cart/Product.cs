using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    internal class Product
    {
        internal string Name;
        internal int Price;
        internal int Amount;


        internal Product(string productName, int productPrice, int productAmount)
        {
            Name = productName;
            Price = productPrice;
            Amount = productAmount;
        }
    }
}

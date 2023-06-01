using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    public class Simple_shoppingCartDemo
    {
        private List<CartItem> _shoppingCart;
        public void Run()
        {
            _shoppingCart = new List<CartItem>();
            BuyProduct("Banana", 10, 5);
            BuyProduct("Banana", 15, 5);
            BuyProduct("Fluespray", 5, 20);
            BuyProduct("Kremflaske", 15, 10);
            ShowCart();
        }

        private void BuyProduct(string name, int price, int amount)
        {
            CartItem reoccurringItem = _shoppingCart.FirstOrDefault(x => x.Product.Name == name);
            if (reoccurringItem == null)
                AddNewProduct(name, price, amount);
            else
                AddExistingProduct(price, amount, reoccurringItem);
        }


        private void AddNewProduct(string name, int price, int amount)
        {
            var product = new Product(name, price);
            var cartItem = new CartItem(product, amount);
            _shoppingCart.Add(cartItem);
            Console.WriteLine($"Du kjøpte {cartItem.Amount} stk. {cartItem.Product.Name}");
        }

        private void AddExistingProduct(int price, int amount, CartItem reoccurringItem)
        {
            var product = reoccurringItem.Product;
            _shoppingCart.Remove(reoccurringItem);
            reoccurringItem.AddAdditionalProduct(amount, price);
            _shoppingCart.Add(reoccurringItem);
            Console.WriteLine($"Du kjøpte {amount} ekstra {product.Name}");
        }

        private void ShowCart()
        {
            if (_shoppingCart.Count == 0)
                Console.WriteLine("Handlekurven er tom.");
            else
            {
                Console.WriteLine("Handlekurv:");
                double totalPrice = 0;
                foreach (CartItem item in _shoppingCart)
                {
                    totalPrice += item.CalculateOrderLinePrice();
                }

                Console.WriteLine($"Totalpris: {totalPrice}kr");
            }
        }
    }
}

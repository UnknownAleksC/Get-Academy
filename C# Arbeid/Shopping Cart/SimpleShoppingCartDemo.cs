using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    internal static class SimpleShoppingCartDemo
    {
        private static List<Product> shoppingCart;
        public static void Run()
        {
            shoppingCart = new List<Product>();
            BuyProduct("Banana", 10, 5);
            BuyProduct("Fluespray", 5, 20);
            BuyProduct("Kremflaske", 15, 10);
            ShowCart();
        }

        private static void BuyProduct(string name, int price, int amount)
        {
            var product = new Product(name, price, amount);
            shoppingCart.Add(product);
            Console.WriteLine($"Du kjøpte {product.Amount} stk. {product.Name}");
        }
        private static void ShowCart()
        {
            if (shoppingCart.Count == 0)
                Console.WriteLine("Handlekurven er tom.");
            else
            {
                Console.WriteLine("Handlekurv:");
                int totalPrice = 0;
                foreach (Product product in shoppingCart)
                {
                    int orderLinePrice = product.Price * product.Amount;
                    totalPrice += orderLinePrice;
                    Console.WriteLine($"{product.Amount}stk {product.Name}, {product.Price}kr per = {orderLinePrice}kr");
                }

                Console.WriteLine($"Totalpris: {totalPrice}kr");
            }
        }
    }
}

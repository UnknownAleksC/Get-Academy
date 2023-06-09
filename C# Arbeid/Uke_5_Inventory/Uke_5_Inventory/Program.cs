namespace Uke_5_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClothingItem shirts = new ClothingItem("Men's T-Shirt", 50, 20.99, "Large", "Blue");

            double salePrice = shirts.CalculateSalePrice();

            Console.WriteLine($"The sale price of {shirts.Quantity} {shirts.Name}s is: {salePrice}");

            ElectronicItem phones = new ElectronicItem("iPhone X", 25, 799.99, "1 year", 50);

            salePrice = phones.CalculateSalePrice();

            Console.WriteLine($"The sale price of {phones.Quantity} {phones.Name}s is: {salePrice}");
        }
    }
}
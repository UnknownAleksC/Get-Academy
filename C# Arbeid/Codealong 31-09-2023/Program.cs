using System.Diagnostics.CodeAnalysis;

namespace Codealong_31_09_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coins = new Coin[]
            {
                new Coin(10, 10),
                new Coin(5, 20),
                new Coin(1, 100)
        };
            //coins[0] = new Coin(10, 10);
            //coins[1] = new Coin(5, 20);
            //coins[2] = new Coin(1, 100);

            int sum = 0;

            foreach (Coin coin in coins)
            {
                sum = coin.CalculateTotalCoinValue();
            }

            //for (int i = 0; coins.Length < 3; i++)
            //{
            //    sum += coins[i].Value * coins[i].Count;
            //}

            Console.WriteLine(sum);
        }
    }
}
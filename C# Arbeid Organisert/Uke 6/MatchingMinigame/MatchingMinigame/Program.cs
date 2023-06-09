using System.Security.Cryptography.X509Certificates;

namespace MatchingMinigame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matchGame = new MatchGame();
            matchGame.RunGame();
            //try
            //{
            //    Reader nice = new Reader();
            //    string name = nice.ReadLine();
            //    Console.WriteLine(name);
            //}
            //catch (TimeoutException)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Time ran out :(");
            //}
        }
    }
}
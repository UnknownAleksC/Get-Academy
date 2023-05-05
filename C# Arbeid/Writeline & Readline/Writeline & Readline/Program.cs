namespace Writeline___Readline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert your name, NOW!");
            var text = Console.ReadLine();
            Console.Write("Hello, " + text + "!");
            Console.Write(" Welcome to my Utopia!");

            //Console.ReadLine();
        }
    }
}
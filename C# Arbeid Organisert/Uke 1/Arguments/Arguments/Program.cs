namespace Arguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args) 
            {
                Console.Write(arg + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Antall argumenter: " + args.Length);
        }
    }
}
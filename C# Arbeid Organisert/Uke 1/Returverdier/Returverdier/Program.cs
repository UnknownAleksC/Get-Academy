namespace Returverdier
{
    internal class Program
    {
        static int num1 = 55;
        static int num2 = 72;

        static void Main(string[] args)
        {
            var sum = calculateSum();
            var message = errorMessage();
            Console.WriteLine(sum);
            Console.WriteLine(message);
        }

        static int calculateSum()
        {
            int sum = num1 + num2;
            return sum;
        }

        static string errorMessage()
        {
            string message = "Denne metoden returnerer ingenting";
            return message;
        }
    }
}
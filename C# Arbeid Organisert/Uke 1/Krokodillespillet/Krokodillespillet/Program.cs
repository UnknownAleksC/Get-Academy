using System.CodeDom.Compiler;

namespace Krokodillespillet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var currentNum = GetRandomNumber();
            var previousNum = GetRandomNumber();
            var userName = "";
            var correctGuesses = 0;
            var wrongGuesses = 0;

            while (string.IsNullOrEmpty(userName))
            {
                Console.Write("Insert your username: ");
                userName = Console.ReadLine();
                Console.Clear();
            }

            while (true)
            {
                Console.WriteLine(userName + "'s Scoreboard:");
                Console.WriteLine("Correct Guesses: " + correctGuesses);
                Console.WriteLine("Wrong Guesses: " + wrongGuesses);
                Console.WriteLine();
                Console.WriteLine("Is the number I'm thinking of higher, lower or equal to the number " + previousNum);
                Console.WriteLine("\">\" - Smaller");
                Console.WriteLine("\"<\" - Bigger");
                Console.WriteLine("\"=\" - Equal");
                Console.WriteLine();
                Console.Write("Your answer: ");

                var userInput = Console.ReadLine();

                correctGuesses = CheckIfGuessIsCorrect(userInput, previousNum, currentNum, correctGuesses, ref wrongGuesses);

                currentNum = GetRandomNumber();
                previousNum = GetRandomNumber();

                Console.Clear();
            }
        }

        private static int CheckIfGuessIsCorrect(string? userInput, int previousNum, int currentNum, int correctGuesses,
            ref int wrongGuesses)
        {
            if (userInput == ">")
            {
                if (previousNum > currentNum)
                {
                    correctGuesses++;
                    Console.WriteLine();
                    Console.Write("The number is " + currentNum + " which means you guessed correct!");
                    Console.ReadLine();
                }
                else
                {
                    wrongGuesses++;
                    Console.WriteLine();
                    Console.Write("The number is " + currentNum + " which means you guessed wrong!");
                    Console.ReadLine();
                }

                ;
            }
            else if (userInput == "<")
            {
                if (previousNum < currentNum)
                {
                    correctGuesses++;
                    Console.WriteLine();
                    Console.Write("The number is " + currentNum + " which means you guessed correct!");
                    Console.ReadLine();
                }
                else
                {
                    wrongGuesses++;
                    Console.WriteLine();
                    Console.Write("The number is " + currentNum + " which means you guessed wrong!");
                    Console.ReadLine();
                }

                ;
            }
            else if (userInput == "=")
            {
                if (previousNum == currentNum)
                {
                    correctGuesses++;
                    Console.WriteLine();
                    Console.Write("The number is " + currentNum + " which means you guessed correct!");
                    Console.ReadLine();
                }
                else
                {
                    wrongGuesses++;
                    Console.WriteLine();
                    Console.Write("The number is " + currentNum + " which means you guessed wrong!");
                    Console.ReadLine();
                }

                ;
            }
            else
            {
                Console.Clear();
                Console.Write("That's not one of the signs I asked for buddy, try again!");
                Console.ReadLine();
            }

            ;
            return correctGuesses;
        }

        static int GetRandomNumber()
        {
            var random = new Random();
            return random.Next(1, 11);
        }
    }
}
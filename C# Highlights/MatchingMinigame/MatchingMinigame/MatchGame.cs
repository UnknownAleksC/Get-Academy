using System.Dynamic;
using MatchingMinigame;
internal class MatchGame
{
    //Player character
    private Player _player = new Player();
    //Instructor character
    private Instructor _instructor = new Instructor();

    //Runs the game
    public void RunGame()
    {
        int wins = 0;
        int losses = 0;
        int amount = 10;

        while (true)
        {
            var intro = File.ReadAllLines("Introduction.txt");

            Console.WriteLine($"Wins: {wins}");
            Console.WriteLine($"Losses: {losses}");
            Console.WriteLine();
            foreach (var line in intro)
                Console.WriteLine(line);

            Console.ReadLine();
            //Gives instructors flag inputs
            _instructor.GetFlagInputs(amount);
            Console.WriteLine($"Repeat the following inputs:");
            _instructor.PrintFlags();
            //Gives players flag inputs
            _player.GetFlagInputs(amount);
            //Compares _intructor and _player inputs
            for (int i = 0; i < _instructor.Flags.Length; i++)
            {
                if (_instructor.Flags[i].GetDirectionKey() != _player.Flags[i].GetDirectionKey())
                {
                    Console.WriteLine();
                    Console.Write("The pattern sadly does not match . . . Game Over!");
                    losses++;
                    break;
                }
                if (i == _instructor.Flags.Length - 1)
                {
                    Console.WriteLine();
                    Console.Write("Congrats you won! Feel free to try again!");
                    wins++;
                }
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}
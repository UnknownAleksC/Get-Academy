using System.Dynamic;

namespace Tippekupong
{
    internal class Program
    {
        public class Match
        {
            public int HomeGoals { get; set; }
            public int AwayGoals { get; set; }
            public string Bet { get; set; }
            public bool IsRunning { get; set; }

            public Match(int homeGoals, int awayGoals, string bet, bool isRunning)
            {
                HomeGoals = homeGoals;
                AwayGoals = awayGoals;
                Bet = bet;
                IsRunning = isRunning;
            }
        }

        static void Main(string[] args)
        {
            Console.Write(
                "Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            var bet = Console.ReadLine();
            var match = new Match(0, 0, bet, true);

            while (match.IsRunning)
            {
                Console.ReadLine();
                char[] options = { 'X', 'H', 'B' };
                var i = new Random().Next(0, options.Length);
                var command = options[i];
                match.IsRunning = command != 'X';
                if (command == 'H') match.HomeGoals++;
                else if (command == 'B') match.AwayGoals++;
                Console.WriteLine($"Stillingen er {match.HomeGoals}-{match.AwayGoals}.");
            }

            var result = match.HomeGoals == match.AwayGoals ? "U" : match.HomeGoals > match.AwayGoals ? "H" : "B";
            var isBetCorrect = match.Bet.Contains(result);
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrectText}");
        }
    }
}
using System.Formats.Asn1;
using System.Net.Sockets;

namespace Tik_Tak_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var board = new Board();
            var gameConsole = new GameConsole(board);
            while (gameConsole.IsActive)
            {
                if (gameConsole.IsPlayer1)
                {
                    gameConsole.Show(board);
                    Console.Write("Skriv inn hvor du vil sette kryss mellom a1 - c3: ");
                    bool round = true;
                    while (round)
                    {
                        var position = Console.ReadLine();
                        round = board.Mark(position, board);
                    }
                    gameConsole.IsPlayer1 = false;
                    foreach (var square in board.Squares)
                    {
                        square.IsPlayer1 = false;
                    }
                }
                else
                {
                    gameConsole.Show(board);
                    board.MarkRandom(board);
                    gameConsole.IsPlayer1 = true;
                    foreach (var square in board.Squares)
                    {
                        square.IsPlayer1 = true;
                    }
                }

                Console.Clear();
            }
        }

        internal void CheckGameStatus(Board board, GameConsole gameConsole)
        {
            var gameBoard = board.Squares;
            if (gameBoard[0].IsTaken && gameBoard[1].IsTaken && gameBoard[2].IsTaken) ;
        }
    }
}
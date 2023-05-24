using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_Tak_Toe
{
    internal class GameConsole
    {
        public bool IsActive { get; set; }
        public bool IsPlayer1 { get; set; }
        internal GameConsole(Board board)
        {
            var _board = board;
            IsActive = true;
            IsPlayer1 = true;
        }
        internal void Show(Board board)
        {
            Console.Write($"  a b c" +
                          $"\r\n ┌─────┐" +
                          $"\r\n1│{board.Squares[0].PlayerIcon} {board.Squares[1].PlayerIcon} {board.Squares[2].PlayerIcon}│" +
                          $"\r\n2│{board.Squares[3].PlayerIcon} {board.Squares[4].PlayerIcon} {board.Squares[5].PlayerIcon}│" +
                          $"\r\n3│{board.Squares[6].PlayerIcon} {board.Squares[7].PlayerIcon} {board.Squares[8].PlayerIcon}│" +
                          $"\r\n └─────┘");
        }
    }
    public class Square
    {
        public bool IsTaken { get; set; }
        public bool IsPlayer1 { get; set; }
        public char PlayerIcon { get; set; }

        public Square()
        {
            IsTaken = false;
            PlayerIcon = ' ';
            IsPlayer1 = true;
        }

        public char SetPlayer()
        {
            if (IsPlayer1) PlayerIcon = '\u00d7';
            else PlayerIcon = 'o';
            IsTaken = true;
            return PlayerIcon;
        }
    }

    internal class Board
    {
        public Square[] Squares { get; }
        internal Board()
        {
            Squares = new Square[9];
            for (int i = 0; i < Squares.Length; i++)
            {
                Squares[i] = new Square();
            }
        }

        public bool CheckSquare(Square square)
        {
            if (square.IsTaken) return true;
            return false;
        }
        internal bool Mark(string position, Board board)
        {
            var columnChar = position[0];
            var rowChar = position[1];
            var columnIndex = columnChar - 'a';
            var rowIndex = rowChar - '1';
            var index = rowIndex * 3 + columnIndex;
            if (index < 0 || index > 8)
            {
                Console.WriteLine("Your placement is not valid, try again!");
                return true;
            }
            else if (!board.CheckSquare(board.Squares[index]))
            {
                board.Squares[index].SetPlayer();
                return false;
            }
            else
            {
                Console.WriteLine("Your placement is not valid, try again!");
                return true;
            }
        }

        internal void MarkRandom(Board board)
        {
            Random _random = new Random();
            var loop = true;
            while (loop)
            {
                var index = _random.Next(0, 9);
                if (!board.CheckSquare(board.Squares[index]))
                {
                    board.Squares[index].SetPlayer();
                    loop = false;
                }
            }
        }

    }
}

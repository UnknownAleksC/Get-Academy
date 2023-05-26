using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Random_Squares
{
    internal class VirtualScreenRow
    {
        private VirtualScreenCell[] _cells;

        public VirtualScreenRow(int screenWidth)
        {
            _cells = new VirtualScreenCell[screenWidth];
            for (int i = 0; i < screenWidth; i++)
                _cells[i] = new VirtualScreenCell();
        }

        public void AddBoxTopRow(int boxX, int boxWidth)
        {
            for (int i = 0; i <= _cells.Length; i++)
            {
                if (i == boxX)
                    _cells[i].AddUpperLeftCorner();
                else if (i == (boxX + boxWidth))
                    _cells[i].AddUpperRightCorner();
                else if (i > boxX && i < boxX + boxWidth)
                    _cells[i].AddHorizontal();
            }
        }

        public void AddBoxBottomRow(int boxX, int boxWidth)
        {
            for (int i = 0; i <= _cells.Length; i++)
            {
                if (i == boxX)
                    _cells[i].AddLowerLeftCorner();
                else if (i == (boxX + boxWidth))
                    _cells[i].AddLowerRightCorner();
                else if (i > boxX && i < (boxX + boxWidth))
                    _cells[i].AddHorizontal();
            }
        }

        public void AddBoxMiddleRow(int boxX, int boxWidth)
        {
            for (int i = 0; i < _cells.Length; i++)
            {
                if (i == boxX || i == boxX + boxWidth)
                    _cells[i].AddVertical();
            }
        }

        public void Show()
        {
            for (int i = 0; i < _cells.Length; i++)
            {
                if (i == _cells.Length - 1)
                    Console.WriteLine(_cells[i].GetCharacter());
                Console.Write(_cells[i].GetCharacter());
            }
        }
    }
}

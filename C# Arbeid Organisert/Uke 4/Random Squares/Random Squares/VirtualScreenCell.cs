using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Random_Squares
{
    internal class VirtualScreenCell
    {
        public bool Up { get; private set; }
        public bool Down { get; private set; }
        public bool Left { get; private set; }
        public bool Right { get; private set; }

        public char GetCharacter()
        {
            return
                Up && Down && Right && Left ? '┼' :
                Down && Left && Right ? '┬' :
                Down && Up && Left ? '┤' :
                Down && Up && Right ? '├' :
                Left && Up && Right ? '┴' :
                Left && Down && Right ? '┬' :
                Down && Right ? '┌' :
                Left && Right ? '─' :
                Down && Left ? '┐' :
                Up && Right ? '└' :
                Up && Left ? '┘' :
                Up && Down ? '│' :
                ' ';
        }

        public void AddHorizontal()
        {
            Left = true;
            Right = true;
        }

        public void AddVertical()
        {
            Up = true;
            Down = true;
        }

        public void AddLowerLeftCorner()
        {
            Up = true;
            Right = true;
        }

        public void AddUpperLeftCorner()
        {
            Down = true;
            Right = true;
        }

        public void AddUpperRightCorner()
        {
            Down = true;
            Left = true;
        }

        public void AddLowerRightCorner()
        {
            Up = true;
            Left = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingMinigame
{
    internal abstract class Flag : IFlag
    {
        protected ConsoleKey? _direction;
        protected Reader reader = new Reader();
        public abstract ConsoleKey? GetDirection();

        public ConsoleKey? GetDirectionKey()
        {
            return _direction;
        }

        public void PrintDirection()
        {
            if (_direction == ConsoleKey.LeftArrow)
                Console.Write("LEFT ");
            if (_direction == ConsoleKey.RightArrow)
                Console.Write("RIGHT ");
            if (_direction == ConsoleKey.UpArrow)
                Console.Write("UP ");
            if (_direction == ConsoleKey.DownArrow)
                Console.Write("DOWN ");
            if (_direction == null)
                Console.Write("SLOW ");
        }
    }
}

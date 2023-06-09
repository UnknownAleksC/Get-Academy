using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingMinigame
{
    internal abstract class Flag : IFlag
    {
        protected ConsoleKey _direction;
        public abstract ConsoleKey GetDirection();
    }
}

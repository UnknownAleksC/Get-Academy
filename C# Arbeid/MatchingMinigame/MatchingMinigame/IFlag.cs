using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace MatchingMinigame
{
    internal interface IFlag
    {
        public ConsoleKey GetDirection();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingMinigame
{
    internal abstract class FlagHolder
    {
        protected IFlag[] _flags;
        public abstract List<ConsoleKey> GetFlagInputs(int amount);
    }
}

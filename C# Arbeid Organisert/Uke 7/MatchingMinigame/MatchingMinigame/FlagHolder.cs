using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingMinigame
{
    internal abstract class FlagHolder
    {
        public IFlag[] Flags;
        public abstract List<ConsoleKey?> GetFlagInputs(int amount);

        public void PrintFlags()
        {
            foreach (var flag in Flags)
            {
                flag.PrintDirection();
            }
            Console.WriteLine();
        }
    }
}

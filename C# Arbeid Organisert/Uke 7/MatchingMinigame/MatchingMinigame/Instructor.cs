using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingMinigame
{
    internal class Instructor : FlagHolder
    {
        public override List<ConsoleKey?> GetFlagInputs(int amount)
        {
            var keyInputs = new List<ConsoleKey?>();
            Flags = new IFlag[amount];
            Flags = Flags.Select(_ => new InstructorFlag()).ToArray();
            foreach (var flag in Flags)
            {
                keyInputs.Add(flag.GetDirection());
            }
            return keyInputs;
        }
    }
}

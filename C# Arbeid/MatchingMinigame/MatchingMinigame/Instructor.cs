using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingMinigame
{
    internal class Instructor : FlagHolder
    {
        public override List<ConsoleKey> GetFlagInputs(int amount)
        {
            var keyInputs = new List<ConsoleKey>();
            _flags = new IFlag[amount];
            _flags = _flags.Select(_ => new InstructorFlag()).ToArray();
            foreach (var flag in _flags)
            {
                keyInputs.Add(flag.GetDirection());
            }
            return keyInputs;
        }
    }
}

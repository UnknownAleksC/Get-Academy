using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klikkerspill
{
    internal class CloseProgram : ICommand
    {
        public void Run(ClickerGame game)
        {
            Environment.Exit(0);
        }
    }
}

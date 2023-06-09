using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klikkerspill
{
    internal class CommandSet
    {
        private ICommand[] commands;

        public CommandSet()
        {
            commands = new ICommand[]
            {
                new Click(),
                new Upgrade(),
                new SuperUpgrade(),
                new CloseProgram()
            };
        }

        public void RunCommand(char key, ClickerGame game)
        {
            if (key is 'X')
                commands[3].Run(game);
            else if (key is ' ')
                commands[0].Run(game);
            else if (key is 'K' && game.Points >= 10)
                commands[1].Run(game);
            else if (key is 'S' && game.Points >= 100)
                commands[2].Run(game);
        }
    }
}

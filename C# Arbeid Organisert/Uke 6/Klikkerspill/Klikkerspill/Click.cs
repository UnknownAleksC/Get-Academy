using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Klikkerspill
{
    internal class Click : ICommand
    {
        public void Run(ClickerGame game)
        {
            game.Points += game.PointsPerClick;
        }
    }
}

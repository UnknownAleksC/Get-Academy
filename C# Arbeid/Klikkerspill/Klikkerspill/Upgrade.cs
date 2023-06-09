using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klikkerspill
{
    internal class Upgrade : ICommand
    {
        public void Run(ClickerGame game)
        {
            game.Points -= 10;
            game.PointsPerClick += game.PointsPerClickIncrease;
        }
    }
}

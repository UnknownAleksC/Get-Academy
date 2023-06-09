using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klikkerspill
{
    internal class SuperUpgrade : ICommand
    {
        public void Run(ClickerGame game)
        {
            game.Points -= 100;
            game.PointsPerClickIncrease++;
        }
    }
}

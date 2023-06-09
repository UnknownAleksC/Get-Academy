using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klikkerspill
{
    internal class ClickerGame
    {
        public int Points = 0;
        public int PointsPerClick = 1;
        public int PointsPerClickIncrease = 1;

        public void RunGame()
        {
            var commandSet = new CommandSet();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Kommandoer:\r\n - SPACE = klikk (og få poeng)\r\n - K = kjøp oppgradering \r\n       øker poeng per klikk \r\n       koster 10 poeng\r\n - S = kjøp superoppgradering \r\n       øker \"poeng per klikk\" for den vanlige oppgraderingen.\r\n       koster 100 poeng\r\n - X = avslutt applikasjonen");
                Console.WriteLine($"Du har {Points} poeng.");
                Console.WriteLine("Trykk tast for ønsket kommando.");
                var key = Console.ReadKey().KeyChar;
                commandSet.RunCommand(key, this);
            }
        }
    }
}

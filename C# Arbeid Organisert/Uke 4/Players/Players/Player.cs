using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    internal class Player
    {
        internal string Name { get; set; }
        internal int Points { get; set; }

        internal Player(string name, int points)
        {
            Name = name;
            Points = points;
        }

        internal void Play(Player player2)
        {
            var random = new Random().Next(0, 1);
            switch (random)
            {
                case 0:
                    Console.WriteLine($"{Name} earned a point and {player2.Name} lost a point");
                    player2.Points -= 1;
                    Points += 1;
                    break;
                default:
                    Console.WriteLine($"{player2.Name} earned a point and {Name} lost a point");
                    Points -= 1;
                    player2.Points += 1;
                    break;
            }
        }

        internal void ShowNameAndPoints()
        {
            Console.WriteLine($"Player {Name}: {Points} points");
        }
    }
}

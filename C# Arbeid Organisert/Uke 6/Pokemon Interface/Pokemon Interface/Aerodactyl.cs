using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Interface
{
    internal class Aerodactyl : IPokemon
    {
        public int Health { get; private set; }

        public Aerodactyl()
        {
            Health = 999;
        }
        public void Attack(IPokemon opponent)
        {
            opponent.LooseHealth(50);
            Console.WriteLine("Aerodactyl attacked the enemy for a whooping 50 dmg!");
        }

        public void LooseHealth(int ap)
        {

        }
    }
}

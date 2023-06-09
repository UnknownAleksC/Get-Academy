using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Interface
{
    internal class Jigglypuff : IPokemon
    {
        public int Health { get; private set; }

        public Jigglypuff()
        {
            Health = 500;
        }
        public void Attack(IPokemon opponent)
        {
            opponent.LooseHealth(25);
            Console.WriteLine("Jigglypuff attacked the enemy for a whooping 25 dmg!");
        }

        public void LooseHealth(int ap)
        {
            Health -= ap;
        }
    }
}
